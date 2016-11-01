#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System;

namespace TNRD.Automatron {

    public class AutomatronLogger {

        private static List<string> logs = new List<string>();
        private static string name;

        public static void Start( string name ) {
            AutomatronLogger.name = name;
            logs.Clear();
        }

        public static void Save() {
            string folder = AutomatronSettings.LogFolder;
            if ( !Directory.Exists( folder ) ) {
                Directory.CreateDirectory( folder );
            }

            var logName = "";

            if ( !string.IsNullOrEmpty( name ) ) {
                logName += name + " ";
            }

            logName += DateTime.Now.ToString( "u" ).Replace( ":", "." );

            var fpath = Utils.GetUniqueFilePath( AutomatronSettings.LogFolder, logName, "log" );
            File.WriteAllLines( fpath, logs.ToArray() );
        }

        public static void SaveAs( string path ) {
            File.WriteAllLines( path, logs.ToArray() );
        }

        private static void AddLog( string message ) {
            logs.Add( string.Format( "[{0}] {1}", DateTime.Now.ToString( "u" ), message ) );
        }

        public static void Log( string message ) {
            AddLog( message );
        }

        public static void Log( object value ) {
            if ( value == null )
                value = "";

            AddLog( value.ToString() );
        }
    }
}
#endif