using UnityEngine;
using UnityEditor;

namespace TNRD.Automatron.Drawers {

    public class HelpDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            EditorGUI.HelpBox( rect, string.Format( "No drawer found for the field '{0}' of type '{1}'", name, ValueType.Name ), MessageType.Warning );
        }
    }
}