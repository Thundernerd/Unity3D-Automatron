#if UNITY_EDITOR
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using TNRD.Automatron;
using UnityEngine.SceneManagement;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( EditorBuildSettingsScene ) )]
    public class EditorBuildSettingsSceneDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            try {
                var scene = (EditorBuildSettingsScene)value;
                SceneAsset asset = null;

                if ( scene != null && !string.IsNullOrEmpty( scene.path ) ) {
                    asset = AssetDatabase.LoadAssetAtPath<SceneAsset>( scene.path );
                }

                var nAsset = EditorGUI.ObjectField( GetControlRect(), asset, typeof( SceneAsset ), true );
                if ( nAsset != asset ) {
                    if ( nAsset != null ) {
                        value = Find( AssetDatabase.GetAssetOrScenePath( nAsset ) );
                    } else {
                        value = null;
                    }
                }

            } catch ( ExitGUIException ) { }
            EditorGUI.EndDisabledGroup();
        }

        private EditorBuildSettingsScene Find( string path ) {
            return EditorBuildSettings.scenes.Where( s => s.path == path ).FirstOrDefault();
        }
    }
}
#endif