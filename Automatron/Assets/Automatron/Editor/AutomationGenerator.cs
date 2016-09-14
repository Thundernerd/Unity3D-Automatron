using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using TNRD.Automatron.Editor.Core;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Generation {

    public class WizardData {
        public Type Type;
        public string Name;
        public Dictionary<FieldInfo, bool> Fields;
        public Dictionary<PropertyInfo, bool> Properties;
        public Dictionary<MethodInfo, bool> Methods;
    }

    public class GenerationData {
        public Type Type;
        public List<MethodInfo> Methods;
        public List<PropertyInfo> Properties;
        public List<FieldInfo> Fields;
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

        public static void Init( List<WizardData> datas ) {
            var wiz = DisplayWizard<GeneratorWizard>( "Select Members", "Generate", "Cancel" );
            wiz.datas = datas;
            wiz.Folds();
        }

        private List<WizardData> datas;
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
                if ( GUILayout.Button( "Toggle" ) ) {
                    var fs = new Dictionary<FieldInfo, bool>( data.Fields );
                    foreach ( var item in data.Fields ) {
                        var k = item.Key; var v = item.Value;
                        fs[k] = !v;
                    }
                    data.Fields = fs;
                }
                fieldScroll = EditorGUILayout.BeginScrollView( fieldScroll, ExtendedGUI.DarkNoneWindowStyle,
                    GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( fieldHeight ), GUILayout.ExpandHeight( true ) );
                EditorGUI.indentLevel++;
                var fields = new Dictionary<FieldInfo, bool>( data.Fields );
                foreach ( var item in data.Fields ) {
                    var k = item.Key;
                    var v = item.Value;
                    v = EditorGUILayout.ToggleLeft( string.Format( "[{0}]\t{1} {2}", k.IsStatic ? "Static" : "Instance", k.FieldType.Name, k.Name ), v );
                    fields[k] = v;
                }
                data.Fields = fields;
                EditorGUI.indentLevel--;
                EditorGUILayout.EndScrollView();
            }

            foldProperties = EditorGUILayout.Foldout( foldProperties, "Properties" );
            if ( foldProperties ) {
                if ( GUILayout.Button( "Toggle" ) ) {
                    var ps = new Dictionary<PropertyInfo, bool>( data.Properties );
                    foreach ( var item in data.Properties ) {
                        var k = item.Key;
                        var v = item.Value;
                        ps[k] = !v;
                    }
                    data.Properties = ps;
                }
                propertyScroll = EditorGUILayout.BeginScrollView( propertyScroll, ExtendedGUI.DarkNoneWindowStyle,
                    GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( propertyHeight ), GUILayout.ExpandHeight( true ) );
                var props = new Dictionary<PropertyInfo, bool>( data.Properties );
                foreach ( var item in data.Properties ) {
                    var k = item.Key;
                    var v = item.Value;
                    var s = false;
                    try { k.GetValue( null, null ); s = true; } catch ( Exception ) { }
                    v = EditorGUILayout.ToggleLeft( string.Format( "[{0}]\t{1} {2}", s ? "Static" : "Instance", k.PropertyType.Name, k.Name ), v );
                    props[k] = v;
                }
                data.Properties = props;
                EditorGUILayout.EndScrollView();
            }

            foldMethods = EditorGUILayout.Foldout( foldMethods, "Methods" );
            if ( foldMethods ) {
                if ( GUILayout.Button( "Toggle" ) ) {
                    var ms = new Dictionary<MethodInfo, bool>( data.Methods );
                    foreach ( var item in data.Methods ) {
                        var k = item.Key;
                        var v = item.Value;
                        ms[k] = !v;
                    }
                    data.Methods = ms;
                }
                methodScroll = EditorGUILayout.BeginScrollView( methodScroll, ExtendedGUI.DarkNoneWindowStyle,
                    GUILayout.MinHeight( 16 ), GUILayout.MaxHeight( methodHeight ), GUILayout.ExpandHeight( true ) );
                var methods = new Dictionary<MethodInfo, bool>( data.Methods );
                foreach ( var item in data.Methods ) {
                    var k = item.Key;
                    var v = item.Value;
                    var n = string.Format( "[{0}]\t{1} {2}(", k.IsStatic ? "Static" : "Instance", k.ReturnType.Name, k.Name );
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
            Generator.Generate( datas.Select( d => new GenerationData() {
                Type = d.Type,
                Fields = d.Fields.Where( f => f.Value ).Select( f => f.Key ).ToList(),
                Properties = d.Properties.Where( p => p.Value ).Select( f => f.Key ).ToList(),
                Methods = d.Methods.Where( m => m.Value ).Select( f => f.Key ).ToList(),
            } ).ToList() );
        }
    }

    public class Generator : EditorWindow {

        public static void CreateMe() {
            var inst = GetWindow<Generator>( "Generator" );
            inst.minSize = new Vector2( 300, 500 );
            inst.maxSize = new Vector2( 700, 1000 );
            inst.Show();
        }

        public static void Generate( List<GenerationData> dataTypes ) {
            EditorCoroutine.Start( GenerateAsync( dataTypes ) );
        }

        private static IEnumerator GenerateAsync( List<GenerationData> dataTypes ) {
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

                var path = string.Format( "{0}/Automatron/Editor/Automations/{1}Automations.cs", Application.dataPath, type.Name );
                Debug.LogFormat( "Writing {0}", type.Name );
                File.WriteAllText( path, builder.ToString() );
                amountDone++;
                yield return null;
            }

            Debug.Log( "Done" );

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
                    if ( item.ParameterType == typeof( Type ) ) {
                        builder.AppendLine( "\t\t[TypeLimit()]" );
                    }
                    var attrs = item.ParameterType.GetCustomAttributes( typeof( DefaultValueAttribute ), false );
                    if ( attrs.Length == 1 ) {
                        var val = ( attrs[0] as DefaultValueAttribute ).Value;
                        builder.AppendLine( string.Format( "\t\tpublic {0} {1} = {2};", GetTypeName( item.ParameterType ), item.Name, ToString( val ) ) );
                    } else {
                        builder.AppendLine( string.Format( "\t\tpublic {0} {1};", GetTypeName( item.ParameterType ), item.Name ) );
                    }
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

        private static string GetTypeName( Type t ) {
            if ( t == null ) return "null";
            return t.FullName.Trim( '&' ).Replace( "+", "." );
        }

        private static string ToString( object value ) {
            if ( value == null ) return "null";
            if ( !value.GetType().IsValueType ) return "null";

            if ( value is bool ) {
                return ( (bool)value ) ? "true" : "false";
            } else if ( value is float ) {
                return value.ToString() + "f";
            } else if ( value is double ) {
                return value.ToString() + "d";
            } else if ( value is Vector2 ) {
                var v = (Vector2)value;
                return string.Format( "new Vector2({0}f,{1}f)", v.x, v.y );
            } else if ( value is Vector3 ) {
                var v = (Vector3)value;
                return string.Format( "new Vector3({0}f,{1}f,{2}f)", v.x, v.y, v.z );
            } else if ( value is Vector4 ) {
                var v = (Vector4)value;
                return string.Format( "new Vector4({0}f,{1}f,{2}f,{3}f)", v.x, v.y, v.z, v.w );
            } else if ( value is Quaternion ) {
                var v = (Quaternion)value;
                return string.Format( "new Quaternion({0}f,{1}f,{2}f,{3}f)", v.x, v.y, v.z, v.w );
            } else if ( value is Bounds ) {
                var v = (Bounds)value;
                return string.Format( "new Bounds({0},{1})", ToString( v.center ), ToString( v.size ) );
            } else if ( value is Rect ) {
                var v = (Rect)value;
                return string.Format( "new Rect({0},{1})", ToString( v.position ), ToString( v.size ) );
            } else if ( value.GetType().IsEnum ) {
                return ( (int)Enum.GetValues( value.GetType() ).GetValue( 0 ) ).ToString();
            }

            return "undefined";
        }

        private object initializer = null;
        private bool isBusy = false;

        private Dictionary<Type, bool> typesEnabled = new Dictionary<Type, bool>();
        private string[] typeNames = new string[0];
        private List<Type> allTypes = new List<Type>();
        private List<Type> selectedTypes = new List<Type>();
        private List<Type> filteredTypes = new List<Type>();

        private bool includeAssemblyCSharp = true;
        private bool includeAssemblyCSharpEditor = true;
        private bool includeMSCorlib = false;
        private bool includeUnityEditor = false;
        private bool includeUnityEngine = false;

        private bool useBaseType = false;
        private int baseTypeIndex = 0;
        private Type baseType { get { return allTypes[baseTypeIndex]; } }

        private string searchQuery = "";

        private Vector2 scrollPosition = new Vector2();

        private void LoadTypes() {
            EditorCoroutine.Start( LoadTypesAsync() );
        }

        private void SelectTypes() {
            EditorCoroutine.Start( SelectTypesAsync() );
        }

        private void FilterTypes() {
            EditorCoroutine.Start( FilterTypesAsync() );
        }

        private IEnumerator LoadTypesAsync() {
            isBusy = true;
            Repaint();
            yield return null;
            var types = new List<Type>();
            yield return null;
            types.AddRange( LoadTypesFromAssembly( "Assembly-CSharp" ) );
            yield return null;
            types.AddRange( LoadTypesFromAssembly( "Assembly-CSharp-Editor" ) );
            yield return null;
            types.AddRange( LoadTypesFromAssembly( "mscorlib" ) );
            yield return null;
            types.AddRange( LoadTypesFromAssembly( "UnityEditor" ) );
            yield return null;
            types.AddRange( LoadTypesFromAssembly( "UnityEngine" ) );
            yield return null;
            types = types.OrderBy( t => t.Name ).ToList();
            yield return null;
            allTypes = types;
            yield return null;
            typesEnabled.Clear();
            typesEnabled.AddRange( types.Select( t => new KeyValuePair<Type, bool>( t, false ) ) );
            yield return null;
            isBusy = false;
            Repaint();
            yield break;
        }
        private IEnumerator LoadNamesAsync() {
            isBusy = true;
            Repaint();
            yield return null;
            var names = allTypes
                .Select( t => string.Format( "{0}/{1}/{2}",
                    t.Assembly.GetName().Name.Replace( ".", "/" ),
                    t.Name[0],
                    t.Name ) );
            yield return null;
            typeNames = names.ToArray();
            yield return null;
            isBusy = true;
            Repaint();
            yield break;
        }
        private IEnumerator SelectTypesAsync() {
            isBusy = true;
            Repaint();
            yield return null;
            var types = new List<Type>();
            yield return null;
            if ( includeAssemblyCSharp ) {
                types.AddRange( LoadTypesFromAssembly( "Assembly-CSharp" ) );
            }
            yield return null;
            if ( includeAssemblyCSharpEditor ) {
                types.AddRange( LoadTypesFromAssembly( "Assembly-CSharp-Editor" ) );
            }
            yield return null;
            if ( includeMSCorlib ) {
                types.AddRange( LoadTypesFromAssembly( "mscorlib" ) );
            }
            yield return null;
            if ( includeUnityEditor ) {
                types.AddRange( LoadTypesFromAssembly( "UnityEditor" ) );
            }
            yield return null;
            if ( includeUnityEngine ) {
                types.AddRange( LoadTypesFromAssembly( "UnityEngine" ) );
            }
            yield return null;
            types = types.OrderBy( t => GetTypeName( t ) ).ToList();
            yield return null;
            selectedTypes = types;
            yield return null;
            isBusy = false;
            Repaint();
            yield break;
        }
        private IEnumerator FilterTypesAsync() {
            isBusy = true;
            yield return null;
            var list = new List<Type>( selectedTypes );
            yield return null;
            if ( useBaseType ) {
                list = list.Where( t => t == baseType || t.IsSubclassOf( baseType ) ).ToList();
                yield return null;
            }
            try {
                list = list.Where( t => Regex.IsMatch( t.Name, searchQuery ) ).ToList();
            } catch ( Exception ) { }
            yield return null;
            filteredTypes = list;
            yield return null;
            isBusy = false;
            yield break;
        }

        private List<Type> LoadTypesFromAssembly( string assemblyName ) {
            var types = new List<Type>();
            var assembly = Assembly.Load( assemblyName );

            types = assembly.GetTypes()
                .Where( t => !t.Name.StartsWith( "<" ) && !t.Name.StartsWith( "$" ) )
                .Where( t => t.IsPublic )
                .Where( t =>
                    ( t.GetMethods( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public )
                        .Where( m => !m.Name.StartsWith( "get_" ) && !m.Name.StartsWith( "set_" ) && !m.Name.StartsWith( "op_" ) && !m.Name.StartsWith( "add_" ) && !m.Name.StartsWith( "remove_" ) )
                        .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                        .Where( m => m.GetGenericArguments().Length == 0 ).Count() > 0 )
                        ||
                    ( t.GetProperties( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public )
                        .Where( p => p.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                        .Where( p => p.CanRead ).Count() > 0 )
                        ||
                    ( t.GetFields( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public )
                        .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 ).Count() > 0 )
                ).ToList();

            return types;
        }

        void OnGUI() {
            if ( initializer == null ) {
                EditorCoroutine.StartMultiple( LoadTypesAsync(), LoadNamesAsync(), SelectTypesAsync(), FilterTypesAsync() );
                initializer = new object();
            }

            EditorGUI.BeginDisabledGroup( isBusy );

            EditorGUILayout.Space();
            EditorGUILayout.LabelField( "Libraries", EditorStyles.boldLabel );

            EditorGUI.indentLevel++;
            EditorGUI.BeginChangeCheck();
            EditorGUIUtility.labelWidth += 30;
            includeAssemblyCSharp = EditorGUILayout.Toggle( "Assembly-CSharp", includeAssemblyCSharp );
            includeAssemblyCSharpEditor = EditorGUILayout.Toggle( "Assembly-CSharp-Editor", includeAssemblyCSharpEditor );
            includeMSCorlib = EditorGUILayout.Toggle( "mscorlib", includeMSCorlib );
            includeUnityEditor = EditorGUILayout.Toggle( "UnityEditor", includeUnityEditor );
            includeUnityEngine = EditorGUILayout.Toggle( "UnityEngine", includeUnityEngine );
            EditorGUIUtility.labelWidth -= 30;
            if ( EditorGUI.EndChangeCheck() ) {
                EditorCoroutine.StartMultiple( SelectTypesAsync(), FilterTypesAsync() );
            }
            EditorGUI.indentLevel--;

            EditorGUILayout.Space();
            EditorGUILayout.LabelField( "Base Type", EditorStyles.boldLabel );
            EditorGUI.indentLevel++;
            EditorGUI.BeginChangeCheck();
            EditorGUIUtility.labelWidth += 30;
            useBaseType = EditorGUILayout.Toggle( "Enable", useBaseType );
            EditorGUIUtility.labelWidth -= 30;
            baseTypeIndex = EditorGUILayout.Popup( baseTypeIndex, typeNames );
            if ( EditorGUI.EndChangeCheck() ) {
                FilterTypes();
            }
            EditorGUI.indentLevel--;

            EditorGUILayout.Space();
            EditorGUILayout.LabelField( "Search", EditorStyles.boldLabel );
            EditorGUI.BeginChangeCheck();
            EditorGUI.indentLevel++;
            searchQuery = EditorGUILayout.TextField( searchQuery );
            EditorGUI.indentLevel--;
            if ( EditorGUI.EndChangeCheck() ) {
                FilterTypes();
            }

            EditorGUILayout.Space();
            EditorGUILayout.LabelField( "Types", EditorStyles.boldLabel );

            scrollPosition = EditorGUILayout.BeginScrollView( scrollPosition );
            EditorGUI.indentLevel++;
            foreach ( var item in filteredTypes ) {
                var value = typesEnabled[item];
                value = EditorGUILayout.ToggleLeft( GetTypeName( item ), value );
                typesEnabled[item] = value;
            }
            EditorGUI.indentLevel--;
            EditorGUILayout.EndScrollView();

            if ( GUILayout.Button( "Generate" ) ) {
                var types = typesEnabled.Where( t => t.Value )
                    .Select( t => t.Key ).Select( t => new WizardData() {
                        Type = t,
                        Name = GetTypeName( t ),
                        Fields = new Dictionary<FieldInfo, bool>().AddRange( GetFields( t ).Select( f => new KeyValuePair<FieldInfo, bool>( f, false ) ) ),
                        Properties = new Dictionary<PropertyInfo, bool>().AddRange( GetProperties( t ).Select( p => new KeyValuePair<PropertyInfo, bool>( p, false ) ) ),
                        Methods = new Dictionary<MethodInfo, bool>().AddRange( GetMethods( t ).Select( m => new KeyValuePair<MethodInfo, bool>( m, false ) ) ),
                    } ).ToList();
                GeneratorWizard.Init( types );
            }

            EditorGUI.EndDisabledGroup();
        }

        private List<MethodInfo> GetMethods( Type type ) {
            var flags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

            return type.GetMethods( flags )
                    .Where( m => !m.Name.StartsWith( "get_" ) && !m.Name.StartsWith( "set_" ) && !m.Name.StartsWith( "op_" ) && !m.Name.StartsWith( "add_" ) && !m.Name.StartsWith( "remove_" ) )
                    .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                    .Where( m => m.GetGenericArguments().Length == 0 ).ToList();
        }

        private List<PropertyInfo> GetProperties( Type type ) {
            var flags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

            return type.GetProperties( flags )
                    .Where( p => p.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 )
                    .Where( p => p.CanRead ).ToList();

        }

        private List<FieldInfo> GetFields( Type type ) {
            var flags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

            return type.GetFields( flags )
                    .Where( m => m.GetCustomAttributes( typeof( ObsoleteAttribute ), false ).Length == 0 ).ToList();
        }
    }
}