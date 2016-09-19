#if UNITY_EDITOR
﻿using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Scene ) )]
    public class SceneDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            try {
                var scene = (Scene)value;
                SceneAsset asset = null;

                if ( !string.IsNullOrEmpty( scene.path ) ) {
                    asset = AssetDatabase.LoadAssetAtPath<SceneAsset>( scene.path );
                }

                var nAsset = EditorGUI.ObjectField( GetControlRect(), asset, typeof( SceneAsset ), true );
                if ( nAsset != null ) {
                    if ( nAsset != asset ) {
                        var path = AssetDatabase.GetAssetOrScenePath( nAsset );
                        var nScene = SceneManager.GetSceneByPath( path );
                        value = nScene;
                    }
                } else {
                    value = null;
                }
            } catch ( ExitGUIException ) { }
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif