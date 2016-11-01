#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Editor.Utilities {

    public class PreferencesWindow {

        private static EditorWindow instance;

        private static Type wndType;
        private static MethodInfo showMethod;

        private static PropertyInfo hasFocus;
        private static FieldInfo sections;
        private static FieldInfo selectedSectionIndex;
        private static FieldInfo refreshCustomPreferences;

        private static void Setup( bool extra ) {
            if ( wndType == null ) {
                var assembly = Assembly.GetAssembly( typeof( EditorWindow ) );
                wndType = assembly.GetType( "UnityEditor.PreferencesWindow" );
                showMethod = wndType.GetMethod( "ShowPreferencesWindow", BindingFlags.Static | BindingFlags.NonPublic );
            }

            if ( extra && sections == null ) {
                hasFocus = wndType.GetProperty( "hasFocus", BindingFlags.Instance | BindingFlags.NonPublic );
                sections = wndType.GetField( "m_Sections", BindingFlags.Instance | BindingFlags.NonPublic );
                selectedSectionIndex = wndType.GetField( "m_SelectedSectionIndex", BindingFlags.Instance | BindingFlags.NonPublic );
                refreshCustomPreferences = wndType.GetField( "m_RefreshCustomPreferences", BindingFlags.Instance | BindingFlags.NonPublic );
            }
        }

        private static void ShowWindow() {
            if ( showMethod != null ) {
                showMethod.Invoke( null, null );
                instance = EditorWindow.GetWindow( Type.GetType( "UnityEditor.PreferencesWindow,UnityEditor" ) );
            }
        }

        public static void Show() {
            Setup( false );
            ShowWindow();
        }

        public static void Show( string name ) {
            Setup( true );
            ShowWindow();
            EditorCoroutine.Start( WaitForLoad( name ) );
        }

        private static IEnumerator WaitForLoad( string name ) {
            if ( instance == null || refreshCustomPreferences == null )
                yield break;

            // Some extra delay for it to start up
            for ( int i = 0; i < 10; i++ ) {
                yield return null;
            }

            while ( !HasFocus() ) {
                yield return null;
            }


            while ( !HasRefreshedCustomPreferences() ) {
                yield return null;
            }

            var secs = (IList)sections.GetValue( instance );
            var ind = GetIndexForSection( name, secs );

            if ( ind == -1 ) {
                yield break;
            }

            selectedSectionIndex.SetValue( instance, ind );
            instance.Repaint();

            yield break;
        }

        private static bool HasFocus() {
            return (bool)hasFocus.GetValue( instance, null );
        }

        private static bool HasRefreshedCustomPreferences() {
            return !(bool)refreshCustomPreferences.GetValue( instance );
        }

        private static int GetIndexForSection( string name, IList sections ) {
            if ( sections.Count == 0 )
                return -1;

            var type = sections[0].GetType();
            var field = type.GetField( "content", BindingFlags.Instance | BindingFlags.Public );

            for ( int i = 0; i < sections.Count; i++ ) {
                var content = (GUIContent)field.GetValue( sections[i] );
                if ( content.text == name )
                    return i;
            }

            return -1;
        }
    }
}
#endif