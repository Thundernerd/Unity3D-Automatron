using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( object ) )]
    public class SystemObjectDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.HelpBox( rect, string.Format( "Placeholder for field '{0}'", name ), MessageType.Info );
        }
    }
}