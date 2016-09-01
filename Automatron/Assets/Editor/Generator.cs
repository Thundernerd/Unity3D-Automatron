using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TNRD.Automatron;
using UnityEditor;
using UnityEngine;

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

    [MenuItem( "Window/Generate" )]
    private static void Init() {
        var inst = GetWindow<Generator>( "Generator" );
        inst.minSize = new Vector2( 300, 500 );
        inst.maxSize = new Vector2( 700, 1000 );
        inst.Show();
    }

    private struct TypeData {
        public Type Type;
        public bool Checked;
        public string Name;
        public List<MethodInfo> Methods;
        public List<PropertyInfo> Properties;
        public List<FieldInfo> Fields;
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

        if ( GUILayout.Button( "Generate" ) ) {
            Generate();
        }
        if ( GUILayout.Button( "Generate All" ) ) {
            GenerateAll();
        }
        EditorGUILayout.BeginHorizontal();
        if ( GUILayout.Button( "<" ) ) {
            scrollpos = new Vector2();
        }
        if ( GUILayout.Button( ">" ) ) {
            scrollpos = new Vector2();
        }
        EditorGUILayout.EndHorizontal();

        EditorGUI.BeginChangeCheck();
        searchPattern = EditorGUILayout.TextField( searchPattern );
        if ( EditorGUI.EndChangeCheck() || doSearch ) {
            doSearch = false;
            if ( datas.Count == 0 ) {
                GetTypes();
            }
            shownDatas = datas.Where( d => d.Name.Contains( searchPattern ) ).ToList();
        }

        scrollpos = EditorGUILayout.BeginScrollView( scrollpos );
        for ( int i = 0; i < shownDatas.Count; i++ ) {
            var item = shownDatas[i];
            item.Checked = EditorGUILayout.ToggleLeft( item.Name, item.Checked );
            shownDatas[i] = item;
        }
        EditorGUILayout.EndScrollView();
    }

    private void Generate() {
        var types = shownDatas
            .Where( d => d.Checked )
            .ToList();
        EditorCoroutine.Start( GenerateAsync( types ) );
    }

    private void GenerateAll() {
        EditorCoroutine.Start( GenerateAsync( shownDatas ) );
    }

    private IEnumerator GenerateAsync( List<TypeData> dataTypes ) {
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
            if ( getMethods && methods.Count > 0 ) {
                skip = false;
            }
            if ( getProperties && properties.Count > 0 ) {
                skip = false;
            }
            if ( getFields && fields.Count > 0 ) {
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
            yield return null;
        }

        Debug.Log( "DONE!" );

        AssetDatabase.Refresh();

        yield break;
    }

    private void WriteMethods( Type type, List<MethodInfo> methods, StringBuilder builder ) {
        for ( int i = 0; i < methods.Count; i++ ) {
            var m = methods[i];

            builder.AppendLine( string.Format( "\t[Automation( \"Generated/{0}/{1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( m.Name ) ) );
            builder.AppendLine( string.Format( "\tclass {2}{0}{1} : Automation ", m.Name, i, type.Name ) + "{" );
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
            builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
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
            builder.AppendLine( "\t}" );
            builder.AppendLine();
        }
    }

    private void WriteProperties( Type type, List<PropertyInfo> properties, StringBuilder builder ) {
        for ( int i = 0; i < properties.Count; i++ ) {
            var p = properties[i];
            var isStatic = false;

            try {
                p.GetValue( null, null );
                isStatic = true;
            } catch ( Exception ) { }

            if ( p.CanRead ) {

                builder.AppendLine( string.Format( "\t[Automation( \"Generated/{0}/Get {1}\" )]",
                    ObjectNames.NicifyVariableName( type.Name ),
                    ObjectNames.NicifyVariableName( p.Name ) ) );
                builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : Automation ", p.Name, i, type.Name ) + "{" );
                builder.AppendLine();

                if ( !isStatic ) {
                    builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
                }

                builder.AppendLine( "\t\t[ReadOnly]" );
                builder.AppendLine( string.Format( "\t\tpublic {0} Result;", GetTypeName( p.PropertyType ) ) );

                builder.AppendLine();

                builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
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
                builder.AppendLine( "\t}" );
                builder.AppendLine();
            }


            /////////////////////////////// SET

            if ( !p.CanWrite ) continue;

            builder.AppendLine( string.Format( "\t[Automation( \"Generated/{0}/Set {1}\" )]",
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

    private void WriteFields( Type type, List<FieldInfo> fields, StringBuilder builder ) {
        for ( int i = 0; i < fields.Count; i++ ) {
            var f = fields[i];

            builder.AppendLine( string.Format( "\t[Automation( \"Generated/{0}/Get {1}\" )]",
                ObjectNames.NicifyVariableName( type.Name ),
                ObjectNames.NicifyVariableName( f.Name ) ) );
            builder.AppendLine( string.Format( "\tclass {2}{0}Get{1} : Automation ", f.Name, i, type.Name ) + "{" );
            builder.AppendLine();

            if ( !f.IsStatic ) {
                builder.AppendLine( string.Format( "\t\tpublic {0} Instance;", GetTypeName( type ) ) );
            }

            builder.AppendLine( "\t\t[ReadOnly]" );
            builder.AppendLine( string.Format( "\t\tpublic {0} Result;", GetTypeName( f.FieldType ) ) );

            builder.AppendLine();

            builder.AppendLine( "\t\tpublic override IEnumerator Execute() {" );
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
            builder.AppendLine( "\t}" );
            builder.AppendLine();

            if ( f.IsInitOnly ) continue;
            /////////////////////////////// SET

            builder.AppendLine( string.Format( "\t[Automation( \"Generated/{0}/Set {1}\" )]",
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

    private string GetTypeName( Type type ) {

        return type.FullName.Trim( '&' ).Replace( "+", "." );
        //return string.Format( "{0}.{1}", type.Namespace, type.FullName ).Trim( '&' );
    }
}
