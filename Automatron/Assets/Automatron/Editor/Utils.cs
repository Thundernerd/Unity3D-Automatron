using System;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public static class Utils {

        public static string GetPrettyName( string name ) {
            var newName = "";

            for ( int i = 0; i < name.Length; i++ ) {
                var c = name[i];
                if ( i == 0 ) {
                    if ( char.IsLetter( c ) ) {
                        newName += char.ToUpper( c );
                    }
                } else if ( char.IsUpper( c ) ) {
                    if ( i + 1 < name.Length && !char.IsUpper( name[i + 1] ) ) {
                        newName += " ";
                        newName += c;
                    } else if ( !char.IsUpper( name[i - 1] ) ) {
                        newName += " ";
                        newName += c;
                    } else {
                        newName += c;
                    }
                } else if ( char.IsSymbol( c ) ) {
                    newName += " ";
                } else if ( char.IsNumber( c ) ) {
                    if ( char.IsNumber( name[i - 1] ) ) {
                        newName += c;
                    } else {
                        newName += " ";
                        newName += c;
                    }
                } else {
                    if ( string.IsNullOrEmpty( newName ) ) {
                        newName += char.ToUpper( c );
                    } else {
                        newName += c;
                    }
                }
            }

            return newName;
        }

        public delegate void DrawElementAction( ref object value, Rect r );
        public static bool SetupTypeSwitch( Type elementType, ref DrawElementAction drawElement ) {
            if ( elementType == typeof( AnimationCurve ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    if ( v == null ) {
                        v = new AnimationCurve();
                    }

                    v = EditorGUI.CurveField( r, (AnimationCurve)v );
                };
            } else if ( elementType == typeof( bool ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.Toggle( r, (bool)v );
                };
            } else if ( elementType == typeof( Bounds ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.BoundsField( r, (Bounds)v );
                };
            } else if ( elementType == typeof( Color ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.ColorField( r, (Color)v );
                };
            } else if ( elementType == typeof( double ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.DoubleField( r, (double)v );
                };
            } else if ( elementType == typeof( Enum ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.EnumPopup( r, (Enum)v );
                };
            } else if ( elementType == typeof( float ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.FloatField( r, (float)v );
                };
            } else if ( elementType == typeof( int ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.IntField( r, (int)v );
                };
            } else if ( elementType == typeof( Quaternion ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    r.y -= r.height;
                    var q = (Quaternion)v;
                    var v4 = new Vector4( q.x, q.y, q.z, q.w );
                    v4 = EditorGUI.Vector4Field( r, "", v4 );
                    q.x = v4.x;
                    q.y = v4.y;
                    q.z = v4.z;
                    q.w = v4.w;
                    v = q;
                };
            } else if ( elementType == typeof( Rect ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.RectField( r, (Rect)v );
                };
            } else if ( elementType == typeof( string ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.TextField( r, (string)v );
                };
            } else if ( elementType == typeof( Vector2 ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.Vector2Field( r, "", (Vector2)v );
                };
            } else if ( elementType == typeof( Vector3 ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.Vector3Field( r, "", (Vector3)v );
                };
            } else if ( elementType == typeof( Vector4 ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    r.y -= r.height;
                    v = EditorGUI.Vector4Field( r, "", (Vector4)v );
                };
            } else if ( elementType.IsEnum ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.EnumPopup( r, (Enum)v );
                };
            } else if ( elementType == typeof( UnityEngine.Object ) || elementType.IsSubclassOf( typeof( UnityEngine.Object ) ) ) {
                drawElement = ( ref object v, Rect r ) => {
                    v = EditorGUI.ObjectField( r, (UnityEngine.Object)v, elementType, true );
                };
            } else {
                drawElement = ( ref object v, Rect r ) => {
                    EditorGUI.HelpBox( r, string.Format( "Type ({0}) is not supported", elementType.Name ), MessageType.Error );
                };

                return false;
            }

            return true;
        }
    }
}