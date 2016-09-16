using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    [InitializeOnLoad]
    public class AutomationTemplator {

        private static readonly string automationTemplate;
        private static readonly string conditionalTemplate;
        private static readonly string loopableTemplate;

        static AutomationTemplator() {
#if AUTOMATRON_LIB
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var names = assembly.GetManifestResourceNames();
            foreach ( var item in names ) {
                Debug.Log( item );
            }
#else
            var assets = AssetDatabase.FindAssets( "Template.cs" ).Select( a => AssetDatabase.GUIDToAssetPath( a ) );
            automationTemplate = ReadAsset( assets.Where( a => a.EndsWith( "AutomationTemplate.cs.txt" ) ).FirstOrDefault() );
            conditionalTemplate = ReadAsset( assets.Where( a => a.EndsWith( "ConditionalTemplate.cs.txt" ) ).FirstOrDefault() );
            loopableTemplate = ReadAsset( assets.Where( a => a.EndsWith( "LoopableTemplate.cs.txt" ) ).FirstOrDefault() );
#endif
        }

        private static string ReadAsset( string path ) {
            if ( string.IsNullOrEmpty( path ) ) return "";
            var asset = AssetDatabase.LoadAssetAtPath<TextAsset>( path );
            return asset.text;
        }

        public static void CreateAutomation( string name ) {
            WriteIt( automationTemplate, name );
        }

        public static void CreateConditionalAutomation( string name ) {
            WriteIt( conditionalTemplate, name );
        }

        public static void CreateLoopableAutomation( string name ) {
            WriteIt( loopableTemplate, name );
        }

        private static void WriteIt( string contents, string name ) {
            var cname = new string( name.Where( c => char.IsLetter( c ) || char.IsDigit( c ) ).ToArray() );
            var temp = contents.Replace( "_header_", name );
            temp = temp.Replace( "_classname_", cname );
            var path = string.Format( "Assets/Automatron/Editor/Automations/{0}Automations.cs", cname );
            if ( File.Exists( path ) ) {
                path = string.Format( "Assets/Automatron/Editor/Automations/{0}Automations_{1}{2}.cs", cname, DateTime.Now.Second, DateTime.Now.Millisecond );
            } else {
                File.WriteAllText( path, temp );
            }
            AssetDatabase.Refresh();
        }
    }
}