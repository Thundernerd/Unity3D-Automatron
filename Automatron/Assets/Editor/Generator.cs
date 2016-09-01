using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TNRD.Automatron;
using TNRD.Editor.Core;
using UnityEditor;
using UnityEngine;

public class TypeData {
    public Type Type;
    public bool Checked;
    public string Name;
    public List<MethodInfo> Methods;
    public List<PropertyInfo> Properties;
    public List<FieldInfo> Fields;
}

public class SelectData {
    public Type Type;
    public string Name;

    public Dictionary<FieldInfo, bool> Fields;
    public Dictionary<PropertyInfo, bool> Properties;
    public Dictionary<MethodInfo, bool> Methods;
}

public static class DictExt {
    public static Dictionary<T, T2> AddRange<T, T2>( this Dictionary<T, T2> dict, IEnumerable<KeyValuePair<T, T2>> values ) {
        foreach ( var item in values ) {
            dict.Add( item.Key, item.Value );
        }
        return dict;
    }
}

public class GeneratorWizard : ScriptableWizard {

    public static void Init( List<TypeData> datas ) {
        var wiz = DisplayWizard<GeneratorWizard>( "Select Members", "Generate", "Cancel" );
        wiz.datas = datas.Select( d => new SelectData() {
            Name = d.Name,
            Type = d.Type,
            Fields = new Dictionary<FieldInfo, bool>().AddRange( d.Fields.Select( f => new KeyValuePair<FieldInfo, bool>( f, false ) ) ),
            Properties = new Dictionary<PropertyInfo, bool>().AddRange( d.Properties.Select( p => new KeyValuePair<PropertyInfo, bool>( p, false ) ) ),
            Methods = new Dictionary<MethodInfo, bool>().AddRange( d.Methods.Select( m => new KeyValuePair<MethodInfo, bool>( m, false ) ) ),
        } ).ToList();

        wiz.Folds();
    }

    private List<SelectData> datas;
    private int index = 0;
    private bool foldFields = true;
    private bool foldProperties = true;
    private bool foldMethods = true;
    private Vector2 fieldScroll = new Vector2();
    private Vector2 propertyScroll = new Vector2();
    private Vector2 methodScroll = new Vector2();

    private void Folds() {
        foldFields = datas[index].Fields.Count > 0;
        foldProperties = datas[index].Properties.Count > 0;
        foldMethods = datas[index].Methods.Count > 0;
    }

    protected override bool DrawWizardGUI() {
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        var data = datas[index];
        EditorGUILayout.LabelField( string.Format( "[{0}/{1}] {2}", index + 1, datas.Count, data.Name ) );

        var fieldHeight = position.height;
        var propertyHeight = position.height;
        var methodHeight = position.height;

        var allOpen = foldFields && foldProperties && foldMethods;
        if ( allOpen ) {
            fieldHeight /= 3;
            propertyHeight /= 3;
            methodHeight /= 3;
        } else {
            if ( foldFields ) {
                if ( foldMethods || foldProperties ) {
                    fieldHeight /= 2;
                }
            }
            if ( foldProperties ) {
                if ( foldFields || foldMethods ) {
                    propertyHeight /= 2;
                }
            }
            if ( foldMethods ) {
                if ( foldFields || foldProperties ) {
                    methodHeight /= 2;
                }
            }
        }

        foldFields = EditorGUILayout.Foldout( foldFields, "Fields" );
        if ( foldFields ) {
            fieldScroll = EditorGUILayout.BeginScrollView( fieldScroll, ExtendedGUI.DarkNoneWindowStyle,
                GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( fieldHeight ), GUILayout.ExpandHeight( true ) );
            EditorGUI.indentLevel++;
            var fields = new Dictionary<FieldInfo, bool>( data.Fields );
            foreach ( var item in data.Fields ) {
                var k = item.Key;
                var v = item.Value;
                v = EditorGUILayout.ToggleLeft( k.FieldType.Name + " " + k.Name, v );
                fields[k] = v;
            }
            data.Fields = fields;
            EditorGUI.indentLevel--;
            EditorGUILayout.EndScrollView();
        }

        foldProperties = EditorGUILayout.Foldout( foldProperties, "Properties" );
        if ( foldProperties ) {
            propertyScroll = EditorGUILayout.BeginScrollView( propertyScroll, ExtendedGUI.DarkNoneWindowStyle,
                GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( propertyHeight ), GUILayout.ExpandHeight( true ) );
            var props = new Dictionary<PropertyInfo, bool>( data.Properties );
            foreach ( var item in data.Properties ) {
                var k = item.Key;
                var v = item.Value;
                v = EditorGUILayout.ToggleLeft( k.PropertyType.Name + " " + k.Name, v );
                props[k] = v;
            }
            data.Properties = props;
            EditorGUILayout.EndScrollView();
        }

        foldMethods = EditorGUILayout.Foldout( foldMethods, "Methods" );
        if ( foldMethods ) {
            methodScroll = EditorGUILayout.BeginScrollView( methodScroll, ExtendedGUI.DarkNoneWindowStyle,
                GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( methodHeight ), GUILayout.ExpandHeight( true ) );
            var methods = new Dictionary<MethodInfo, bool>( data.Methods );
            foreach ( var item in data.Methods ) {
                var k = item.Key;
                var v = item.Value;
                var n = string.Format( "{0} {1}(", k.ReturnType.Name, k.Name );
                var ps = k.GetParameters();
                for ( int i = 0; i < ps.Length; i++ ) {
                    var p = ps[i];
                    n += string.Format( "{0} {1}", p.ParameterType.Name, p.Name );
                    if ( i < ps.Length - 1 ) n += ",";
                }
                n += ")";
                v = EditorGUILayout.ToggleLeft( n, v );
                methods[k] = v;
            }
            data.Methods = methods;
            EditorGUILayout.EndScrollView();
        }

        var r = EditorGUILayout.GetControlRect();
        if ( GUI.Button( new Rect( r.x, r.y, r.width / 2, r.height ), "<" ) ) {
            index = Mathf.Max( 0, index - 1 );
            Folds();
        }
        if ( GUI.Button( new Rect( r.x + r.width / 2, r.y, r.width / 2, r.height ), ">" ) ) {
            index = Math.Min( index + 1, datas.Count - 1 );
            Folds();
        }

        return true;
    }

    void OnWizardCreate() {
        Generator.Generate( datas.Select( d => new TypeData() {
            Name = d.Name,
            Type = d.Type,
            Checked = true,
            Fields = d.Fields.Where( f => f.Value ).Select( f => f.Key ).ToList(),
            Properties = d.Properties.Where( p => p.Value ).Select( f => f.Key ).ToList(),
            Methods = d.Methods.Where( m => m.Value ).Select( f => f.Key ).ToList(),
        } ).ToList() );
    }
}

public class Generator : EditorWindow {

    private bool getMethods = true;
    private bool getMethodsStatic = true;
    private bool getMethodsInstance = false;

    private bool getProperties = true;
    private bool getPropertiesStatic = true;
    private bool getPropertiesInstance = false;

    private bool getFields = true;
    private bool getFieldsStatic = true;
    private bool getFieldsInstance = false;

    private bool includeSystem;

    private bool fold = false;

    [MenuItem( "Window/Generator" )]
    private static void Init() {
        var inst = GetWindow<Generator>( "Generator" );
        inst.minSize = new Vector2( 300, 500 );
        inst.maxSize = new Vector2( 700, 1000 );
        inst.Show();
    }

    private bool initialized = false;

    private List<TypeData> datas = new List<TypeData>();
    private List<TypeData> shownDatas = new List<TypeData>();

    private bool doSearch = false;

    void GetTypes() {
        datas.Clear();
        doSearch = true;

        var uEngine = GetTypes( Assembly.GetAssembly( typeof( MonoBehaviour ) ) );
        var uEditor = GetTypes( Assembly.GetAssembly( typeof( EditorWindow ) ) );

        datas.AddRange( uEngine );
        datas.AddRange( uEditor );

        if ( includeSystem ) {
            datas.AddRange( GetTypes( Assembly.Load( "mscorlib" ) ) );
        }

        datas = datas.OrderBy( d => d.Name ).ToList();
    }

    private List<TypeData> GetTypes( Assembly assembly ) {
        var types = assembly.GetTypes()
            .Where( t => !t.Name.StartsWith( "<" ) && !t.Name.StartsWith( "$" ) )
            .Where( t => t.IsPublic )
            .OrderBy( t => t.FullName ).ToList();

        var dTypes = new List<TypeData>();

        for ( int i = types.Count - 1; i >= 0; i-- ) {
            var type = types[i];

            var dt = new TypeData() {
                Checked = false,
                Name = type.FullName,
                Type = type,
                Methods = new List<MethodInfo>(),
                Properties = new List<PropertyInfo>(),
                Fields = new List<FieldInfo>()
            };

            BindingFlags flags;

            if ( getMethods ) {
                flags = BindingFlags.DeclaredOnly | BindingFlags.Public;
                if ( getMethodsInstance ) flags |= BindingFlags.Instance;
                if ( getMethodsStatic ) flags |= BindingFlags.Static;

                dt.Methods = type.GetMethods( flags )
                            .Where( m => !m.Name.StartsWith( "get_" ) && !m.Name.StartsWith( "set_" ) && !m.Name.StartsWith( "op_" ) && !m.Name.StartsWith( "add_" ) && !m.Name.StartsWith( "remove_" ) )
                            .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                            .Where( m => m.GetGenericArguments().Length == 0 ).ToList();
            }

            if ( getProperties ) {
                flags = BindingFlags.DeclaredOnly | BindingFlags.Public;
                if ( getPropertiesInstance ) flags |= BindingFlags.Instance;
                if ( getPropertiesStatic ) flags |= BindingFlags.Static;

                dt.Properties = type.GetProperties( flags )
                    .Where( p => p.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                    .Where( p => p.CanRead ).ToList();
            }

            if ( getFields ) {
                flags = BindingFlags.DeclaredOnly | BindingFlags.Public;
                if ( getFieldsInstance ) flags |= BindingFlags.Instance;
                if ( getFieldsStatic ) flags |= BindingFlags.Static;

                dt.Fields = type.GetFields( flags )
                        .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 ).ToList();
            }


            if ( ( getMethods && dt.Methods.Count > 0 ) || ( getProperties && dt.Properties.Count > 0 ) || ( getFields && dt.Fields.Count > 0 ) ) {
                dTypes.Add( dt );
            }
        }

        return dTypes;
    }

    private List<MethodInfo> GetMethods( Type type ) {
        var flags = BindingFlags.DeclaredOnly;
        if ( getMethodsInstance ) flags |= BindingFlags.Instance;
        if ( getMethodsStatic ) flags |= BindingFlags.Static;

        var list = new List<MethodInfo>();
        return type.GetMethods( flags )
                .Where( m => !m.Name.StartsWith( "get_" ) && !m.Name.StartsWith( "set_" ) && !m.Name.StartsWith( "op_" ) && !m.Name.StartsWith( "add_" ) && !m.Name.StartsWith( "remove_" ) )
                .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                .Where( m => m.GetGenericArguments().Length == 0 ).ToList();
    }

    private List<PropertyInfo> GetProperties( Type type ) {
        var flags = BindingFlags.DeclaredOnly;
        if ( getPropertiesInstance ) flags |= BindingFlags.Instance;
        if ( getPropertiesStatic ) flags |= BindingFlags.Static;

        return type.GetProperties( flags )
                .Where( p => p.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                .Where( p => p.CanRead ).ToList();

    }

    private List<FieldInfo> GetFields( Type type ) {
        var flags = BindingFlags.DeclaredOnly;
        if ( getFieldsInstance ) flags |= BindingFlags.Instance;
        if ( getFieldsStatic ) flags |= BindingFlags.Static;

        return type.GetFields( flags )
                .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 ).ToList();
    }

    private Vector2 scrollpos = new Vector2();

    private string searchPattern = "";
    private int offset = 0;

    void OnGUI() {
        if ( !initialized ) {
            GetTypes();
            initialized = true;
        }

        fold = EditorGUILayout.Foldout( fold, "Settings" );
        if ( fold ) {
            EditorGUI.BeginChangeCheck();
            getMethods = EditorGUILayout.ToggleLeft( "Methods", getMethods );
            EditorGUI.indentLevel++;
            EditorGUI.BeginDisabledGroup( !getMethods );
            getMethodsInstance = EditorGUILayout.ToggleLeft( "Instance", getMethodsInstance );
            getMethodsStatic = EditorGUILayout.ToggleLeft( "Static", getMethodsStatic );
            EditorGUI.EndDisabledGroup();
            EditorGUI.indentLevel--;

            getProperties = EditorGUILayout.ToggleLeft( "Properties", getProperties );
            EditorGUI.indentLevel++;
            EditorGUI.BeginDisabledGroup( !getProperties );
            getPropertiesInstance = EditorGUILayout.ToggleLeft( "Instance", getPropertiesInstance );
            getPropertiesStatic = EditorGUILayout.ToggleLeft( "Static", getPropertiesStatic );
            EditorGUI.EndDisabledGroup();
            EditorGUI.indentLevel--;

            getFields = EditorGUILayout.ToggleLeft( "Fields", getFields );
            EditorGUI.indentLevel++;
            EditorGUI.BeginDisabledGroup( !getFields );
            getFieldsInstance = EditorGUILayout.ToggleLeft( "Instance", getFieldsInstance );
            getFieldsStatic = EditorGUILayout.ToggleLeft( "Static", getFieldsStatic );
            EditorGUI.EndDisabledGroup();
            EditorGUI.indentLevel--;

            EditorGUILayout.Space();
            includeSystem = EditorGUILayout.ToggleLeft( "Include System", includeSystem );

            if ( EditorGUI.EndChangeCheck() ) {
                GetTypes();
            }
        }

        if ( GUILayout.Button( "Clear" ) ) {
            foreach ( var item in datas ) {
                item.Checked = false;
            }
        }
        if ( GUILayout.Button( "Generate" ) ) {
            GeneratorWizard.Init( datas.Where( d => d.Checked ).ToList() );
        }
        if ( GUILayout.Button( "Generate All" ) ) {
            GeneratorWizard.Init( datas );
        }
        EditorGUILayout.BeginHorizontal();
        if ( GUILayout.Button( "<" ) ) {
            scrollpos = new Vector2();
            offset -= 50;
            if ( offset < 0 ) {
                offset = 0;
            }
        }
        if ( GUILayout.Button( ">" ) ) {
            scrollpos = new Vector2();
            offset += 50;
        }

        EditorGUILayout.EndHorizontal();

        EditorGUI.BeginChangeCheck();
        searchPattern = EditorGUILayout.TextField( searchPattern );
        if ( EditorGUI.EndChangeCheck() || doSearch ) {
            doSearch = false;
            if ( datas.Count == 0 ) {
                GetTypes();
            }
            offset = 0;
            scrollpos = new Vector2();
            shownDatas = datas.Where( d => d.Name.Contains( searchPattern ) ).ToList();
        }

        scrollpos = EditorGUILayout.BeginScrollView( scrollpos );
        for ( int i = offset; i < Mathf.Min( offset + 50, shownDatas.Count ); i++ ) {
            var item = shownDatas[i];
            item.Checked = EditorGUILayout.ToggleLeft( item.Name, item.Checked );
            shownDatas[i] = item;

            var data = datas.Where( d => d.Name == item.Name ).FirstOrDefault();
            if ( data != null ) {
                data.Checked = item.Checked;
            }
        }
        EditorGUILayout.EndScrollView();
    }

    public static void Generate( List<TypeData> dataTypes ) {
        EditorCoroutine.Start( GenerateAsync( dataTypes ) );
    }

    private static IEnumerator GenerateAsync( List<TypeData> dataTypes ) {
        var amountDone = 0;

        foreach ( var typeData in dataTypes ) {
            var type = typeData.Type;
            var methods = typeData.Methods;
            var properties = typeData.Properties;
            var fields = typeData.Fields;

            for ( int i = methods.Count - 1; i >= 0; i-- ) {
                try {
                    var p = methods[i].GetParameters();
                    GetTypeName( methods[i].ReturnType );
                    foreach ( var item in p ) {
                        GetTypeName( item.ParameterType );
                    }
                } catch ( Exception ) {
                    methods.RemoveAt( i );
                }
            }

            var skip = true;
            if ( methods.Count > 0 ) {
                skip = false;
            }
            if ( properties.Count > 0 ) {
                skip = false;
            }
            if ( fields.Count > 0 ) {
                skip = false;
            }

            if ( skip ) {
                Debug.LogFormat( "Skipping {0}", type.Name );
                continue;
            }

            var builder = new StringBuilder();
            builder.AppendLine( "using System.Collections;" );
            builder.AppendLine();
            builder.AppendLine( "namespace TNRD.Automatron.Automations.Generated {" );
            builder.AppendLine( "#pragma warning disable 0649" );
            builder.AppendLine();

            WriteFields( type, fields, builder );
            WriteProperties( type, properties, builder );
            WriteMethods( type, methods, builder );

            builder.AppendLine();
            builder.AppendLine( "#pragma warning restore 0649" );
            builder.AppendLine( "}" );

            var path = string.Format( "{0}/Automatron/Editor/Automations/Generated/{1}.cs", Application.dataPath, type.Name );
            File.WriteAllText( path, builder.ToString() );
            amountDone++;
            yield return null;
        }

        Debug.LogFormat( "Done; Written {0}", amountDone );

        AssetDatabase.Refresh();

        yield break;
    }

    private static void WriteMethods( Type type, List<MethodInfo> methods, StringBuilder builder ) {
        for ( int i = 0; i < methods.Count; i++ ) {
            var m = methods[i];
            var isConditional = m.ReturnType == typeof( bool );

            builder.AppendLine( string.Format( "\t[Automation( \"{0}/{1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( m.Name ) ) );
            if ( isConditional ) {
                builder.AppendLine( string.Format( "\tclass {2}{0}{1} : ConditionalAutomation ", m.Name, i, type.Name ) + "{" );
            } else {
                builder.AppendLine( string.Format( "\tclass {2}{0}{1} : Automation ", m.Name, i, type.Name ) + "{" );
            }
            builder.AppendLine();

            if ( !m.IsStatic ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
            }

            var parameters = m.GetParameters();
            foreach ( var item in parameters ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} {1};", GetTypeName( item.ParameterType ), item.Name ) );
            }

            if ( m.ReturnType != typeof( void ) ) {
                builder.AppendLine( "\t\t[ReadOnly]" );
                builder.AppendLine( string.Format( "\t\tpublic {0} Result;", GetTypeName( m.ReturnType ) ) );
            }

            builder.AppendLine();
            if ( isConditional ) {
                builder.AppendLine( "\t\tpublic override IEnumerator ExecuteCondition() {" );
            } else {
                builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
            }

            if ( m.ReturnType != typeof( void ) ) {
                builder.Append( "\t\t\tResult = " );
            } else {
                builder.Append( "\t\t\t" );
            }
            if ( m.IsStatic ) {
                builder.AppendFormat( "{0}.{1}(", GetTypeName( type ), m.Name );
            } else {
                builder.AppendFormat( "Instance.{0}(", m.Name );
            }
            for ( int j = 0; j < parameters.Length; j++ ) {
                var p = parameters[j];
                if ( p.ParameterType.IsByRef && !p.IsOut ) {
                    builder.Append( "ref " );
                }
                if ( p.IsOut ) {
                    builder.Append( "out " );
                }
                builder.Append( p.Name );
                if ( j < parameters.Length - 1 ) {
                    builder.AppendFormat( "," );
                }
            }
            builder.AppendLine( ");" );
            builder.AppendLine( "\t\t\tyield break;" );


            builder.AppendLine( "\t\t}" );
            builder.AppendLine();

            if ( isConditional ) {
                builder.AppendLine( "\t\tpublic override bool GetConditionalResult() {" );
                builder.AppendLine( "\t\t\treturn Result;" );
                builder.AppendLine( "\t\t}" );
            }

            builder.AppendLine( "\t}" );
            builder.AppendLine();
        }
    }

    private static void WriteProperties( Type type, List<PropertyInfo> properties, StringBuilder builder ) {
        for ( int i = 0; i < properties.Count; i++ ) {
            var p = properties[i];
            var isStatic = false;
            var isBool = p.PropertyType == typeof( bool );

            try {
                p.GetValue( null, null );
                isStatic = true;
            } catch ( Exception ) { }

            if ( p.CanRead ) {

                builder.AppendLine( string.Format( "\t[Automation( \"{0}/Get {1}\" )]",
                    ObjectNames.NicifyVariableName( type.Name ),
                    ObjectNames.NicifyVariableName( p.Name ) ) );
                if ( isBool ) {
                    builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : ConditionalAutomation ", p.Name, i, type.Name ) + "{" );
                } else {
                    builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : Automation ", p.Name, i, type.Name ) + "{" );
                }
                builder.AppendLine();

                if ( !isStatic ) {
                    builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
                }

                builder.AppendLine( "\t\t[ReadOnly]" );
                builder.AppendLine( string.Format( "\t\tpublic {0} Result;", GetTypeName( p.PropertyType ) ) );

                builder.AppendLine();

                if ( isBool ) {
                    builder.AppendLine( "\t\tpublic override IEnumerator ExecuteCondition() {" );
                } else {
                    builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
                }
                builder.Append( "\t\t\tResult = " );
                if ( isStatic ) {
                    builder.AppendFormat( "{0}.{1}", GetTypeName( type ), p.Name );
                } else {
                    builder.AppendFormat( "Instance.{0}", p.Name );
                }
                builder.AppendLine( ";" );
                builder.AppendLine( "\t\t\tyield break;" );


                builder.AppendLine( "\t\t}" );
                builder.AppendLine();

                if ( isBool ) {
                    builder.AppendLine( "\t\tpublic override bool GetConditionalResult() {" );
                    builder.AppendLine( "\t\t\treturn Result;" );
                    builder.AppendLine( "\t\t}" );
                }

                builder.AppendLine( "\t}" );
                builder.AppendLine();
            }


            /////////////////////////////// SET

            if ( !p.CanWrite ) continue;

            builder.AppendLine( string.Format( "\t[Automation( \"{0}/Set {1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( p.Name ) ) );
            builder.AppendLine( string.Format( "\tclass {2}{0}Set{1} : Automation ", p.Name, i, type.Name ) + "{" );
            builder.AppendLine();

            if ( !isStatic ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
            }

            builder.AppendLine( string.Format( "\t\tpublic {0} Value;", GetTypeName( p.PropertyType ) ) );

            builder.AppendLine();

            builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
            if ( isStatic ) {
                builder.AppendFormat( "\t\t\t{0}.{1}", GetTypeName( type ), p.Name );
            } else {
                builder.AppendFormat( "\t\t\tInstance.{0}", p.Name );
            }
            builder.AppendLine( " = Value;" );
            builder.AppendLine( "\t\t\tyield break;" );


            builder.AppendLine( "\t\t}" );
            builder.AppendLine();
            builder.AppendLine( "\t}" );
            builder.AppendLine();
        }
    }

    private static void WriteFields( Type type, List<FieldInfo> fields, StringBuilder builder ) {
        for ( int i = 0; i < fields.Count; i++ ) {
            var f = fields[i];
            var isBool = f.FieldType == typeof( bool );

            builder.AppendLine( string.Format( "\t[Automation( \"{0}/Get {1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( f.Name ) ) );
            if ( isBool ) {
                builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : ConditionalAutomation ", f.Name, i, type.Name ) + "{" );
            } else {
                builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : Automation ", f.Name, i, type.Name ) + "{" );
            }
            builder.AppendLine();

            if ( !f.IsStatic ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
            }

            builder.AppendLine( "\t\t[ReadOnly]" );
            builder.AppendLine( string.Format( "\t\tpublic {0} Result;", GetTypeName( f.FieldType ) ) );

            builder.AppendLine();

            if ( isBool ) {
                builder.AppendLine( "\t\tpublic override IEnumerator ExecuteCondition() {" );
            } else {
                builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
            }
            builder.Append( "\t\t\tResult = " );
            if ( f.IsStatic ) {
                builder.AppendFormat( "{0}.{1}", GetTypeName( type ), f.Name );
            } else {
                builder.AppendFormat( "Instance.{0}", f.Name );
            }
            builder.AppendLine( ";" );
            builder.AppendLine( "\t\t\tyield break;" );


            builder.AppendLine( "\t\t}" );
            builder.AppendLine();

            if ( isBool ) {
                builder.AppendLine( "\t\tpublic override bool GetConditionalResult() {" );
                builder.AppendLine( "\t\t\treturn Result;" );
                builder.AppendLine( "\t\t}" );
            }

            builder.AppendLine( "\t}" );
            builder.AppendLine();

            if ( f.IsInitOnly ) continue;
            /////////////////////////////// SET

            builder.AppendLine( string.Format( "\t[Automation( \"{0}/Set {1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( f.Name ) ) );
            builder.AppendLine( string.Format( "\tclass {2}{0}Set{1} : Automation ", f.Name, i, type.Name ) + "{" );
            builder.AppendLine();

            if ( !f.IsStatic ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
            }

            builder.AppendLine( string.Format( "\t\tpublic {0} Value;", GetTypeName( f.FieldType ) ) );

            builder.AppendLine();

            builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
            if ( f.IsStatic ) {
                builder.AppendFormat( "\t\t\t{0}.{1}", GetTypeName( type ), f.Name );
            } else {
                builder.AppendFormat( "\t\t\tInstance.{0}", f.Name );
            }
            builder.AppendLine( " = Value;" );
            builder.AppendLine( "\t\t\tyield break;" );


            builder.AppendLine( "\t\t}" );
            builder.AppendLine();
            builder.AppendLine( "\t}" );
            builder.AppendLine();
        }
    }

    private static string GetTypeName( Type type ) {
        return type.FullName.Trim( '&' ).Replace( "+", "." );
    }
}
