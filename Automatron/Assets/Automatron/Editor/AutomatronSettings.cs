#if UNITY_EDITOR
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

        public class EditorPrefsColor : EditorPrefsItem<Color> {

            private string R;
            private string G;
            private string B;
            private string A;

            public EditorPrefsColor( string key, string label, Color defaultValue )
                : base( key, label, defaultValue ) {
                R = Key + "_R";
                G = Key + "_G";
                B = Key + "_B";
                A = Key + "_A";
            }

            public override Color Value {
                get {
                    if ( EditorPrefs.GetBool( Key, false ) ) {
                        return new Color(
                            EditorPrefs.GetFloat( R, 1 ),
                            EditorPrefs.GetFloat( G, 1 ),
                            EditorPrefs.GetFloat( B, 1 ),
                            EditorPrefs.GetFloat( A, 1 ) );
                    } else {
                        return DefaultValue;
                    }
                }
                set {
                    EditorPrefs.SetBool( Key, true );
                    EditorPrefs.SetFloat( Key + "_R", value.r );
                    EditorPrefs.SetFloat( Key + "_G", value.g );
                    EditorPrefs.SetFloat( Key + "_B", value.b );
                    EditorPrefs.SetFloat( Key + "_A", value.a );
                }
            }

            public override void Draw() {
                Value = EditorGUILayout.ColorField( Label, Value );
            }
        }

        private static string projectName {
            get {
                var s = Application.dataPath.Split( '/' );
                var p = s[s.Length - 2];
                return p;
            }
        }

        public static EditorPrefsString ConfigFolder = new EditorPrefsString( "TNRD.Automatron.ConfigFolder." + projectName, "Config Folder", "Assets/Automatron/Configs/" );
        public static EditorPrefsString AutomationFolder = new EditorPrefsString( "TNRD.Automatron.AutomationFolder." + projectName, "Automations Folder", "Assets/Automatron/Editor/Automations/" );
        public static EditorPrefsBool AutoSave = new EditorPrefsBool( "TNRD.Automatron.AutoSave." + projectName, "Auto Save", true );
        public static EditorPrefsBool FirstRun = new EditorPrefsBool( "TNRD.Automatron.FirstRun." + projectName, "Auto Save", true );
        public static EditorPrefsColor AutomationLineColor = new EditorPrefsColor( "TNRD.Automatron.AutomationLineColor." + projectName, "Automation Line Color", Color.white );
        public static EditorPrefsColor FieldLineColor = new EditorPrefsColor( "TNRD.Automatron.FieldLineColor." + projectName, "Field Line Color", Color.white );
        public static EditorPrefsBool FocusNewAutomation = new EditorPrefsBool( "TNRD.Automatron.FocusNewAutomation." + projectName, "Focus New Automation", true );
        public static EditorPrefsBool FocusActiveAutomation = new EditorPrefsBool( "TNRD.Automatron.FocusActiveAutomation." + projectName, "Focus Active Automation", true );

        [PreferenceItem( "Automatron" )]
        public static void PreferencesGUI() {
            AutomationFolder.Draw();
            ConfigFolder.Draw();
            AutoSave.Draw();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField( "Look & Feel", EditorStyles.boldLabel );

            AutomationLineColor.Draw();
            FieldLineColor.Draw();
            FocusActiveAutomation.Draw();
            FocusNewAutomation.Draw();

            GUILayout.FlexibleSpace();
            EditorGUILayout.LabelField( "Version 1.0", EditorStyles.centeredGreyMiniLabel );
        }
    }
}
#endif