using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomatronSettings {

        public abstract class EditorPrefsItem<T> {
            public string Key;
            public string Label;
            public T DefaultValue;

            public EditorPrefsItem( string key, string label, T defaultValue ) {
                if ( string.IsNullOrEmpty( key ) ) {
                    throw new System.ArgumentNullException( "key" );
                }

                Key = key;
                Label = label;
                DefaultValue = defaultValue;
            }

            public abstract T Value { get; set; }
            public abstract void Draw();

            public static implicit operator T( EditorPrefsItem<T> s ) {
                return s.Value;
            }
        }

        public class EditorPrefsInt : EditorPrefsItem<int> {

            public EditorPrefsInt( string key, string label, int defaultValue )
                : base( key, label, defaultValue ) { }

            public override int Value {
                get { return EditorPrefs.GetInt( Key, DefaultValue ); }
                set { EditorPrefs.SetInt( Key, value ); }
            }

            public override void Draw() {
                Value = EditorGUILayout.IntField( Label, Value );
            }
        }

        public class EditorPrefsString : EditorPrefsItem<string> {

            public EditorPrefsString( string key, string label, string defaultValue )
                : base( key, label, defaultValue ) { }

            public override string Value {
                get { return EditorPrefs.GetString( Key, DefaultValue ); }
                set { EditorPrefs.SetString( Key, value ); }
            }

            public override void Draw() {
                Value = EditorGUILayout.TextField( Label, Value );
            }
        }

        public class EditorPrefsBool : EditorPrefsItem<bool> {

            public EditorPrefsBool( string key, string label, bool defaultValue )
                : base( key, label, defaultValue ) { }

            public override bool Value {
                get { return EditorPrefs.GetBool( Key, DefaultValue ); }
                set { EditorPrefs.SetBool( Key, value ); }
            }

            public override void Draw() {
                Value = EditorGUILayout.Toggle( Label, Value );
            }
        }

        public static EditorPrefsString ConfigFolder = new EditorPrefsString( "TNRD.Automatron.ConfigFolder", "Config Folder", Application.dataPath + "/Automatron/Configs/" );
        public static EditorPrefsBool AutoSave = new EditorPrefsBool( "TNRD.Automatron.AutoSave", "Auto Save", true );

        [PreferenceItem( "Automatron" )]
        public static void PreferencesGUI() {
            ConfigFolder.Draw();
            AutoSave.Draw();

            GUILayout.FlexibleSpace();
            EditorGUILayout.LabelField( "Version 1.0", EditorStyles.centeredGreyMiniLabel );
        }
    }
}