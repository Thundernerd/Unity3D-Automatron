#if UNITY_EDITOR
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( AutomatronConfig ) )]
    public class AutomatronConfigDrawer : AutomationDrawer {

        private int index = -1;
        private string[] files;
        private string[] labels;

        public override void Initialize() {
            files = Directory.GetFiles( Application.dataPath, "*.acfg", SearchOption.AllDirectories );
            labels = files.Select( f => Path.GetFileNameWithoutExtension( f ) ).ToArray();
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            if ( value == null ) {
                value = new AutomatronConfig();
            } else if ( index == -1 ) {
                var path = ( (AutomatronConfig)value ).Path;
                for ( int i = 0; i < files.Length; i++ ) {
                    if ( files[i] == path ) {
                        index = i;
                        break;
                    }
                }
            }
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            index = EditorGUI.Popup( GetControlRect(), index, labels );
            if ( index != -1 )
                ( (AutomatronConfig)value ).Path = files[index];
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif