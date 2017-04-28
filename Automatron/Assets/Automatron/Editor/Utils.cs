#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron
{

    public static class Utils
    {

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

        public static bool IsDictionary( this Type type ) {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof( Dictionary<,> );
        }

        public static bool IsList( this Type type ) {
            return type.GetInterfaces().Contains( typeof( IList ) );
        }

        public static bool IsArray( this Type type ) {
            return type.IsArray || type == typeof( Array );
        }

        public static bool IsIEnumerable( this Type type ) {
            return type.FullName.StartsWith( "System.Collections.Generic.IEnumerable" );
        }

        public static bool IsIList( this Type type ) {
            return type.FullName.StartsWith( "System.Collections.Generic.IList" );
        }

        public static Type GetGenericType( this Type type, int index = 0 ) {
            var elementType = type.GetElementType();
            if ( elementType != null )
                return elementType;

            var genericArguments = type.GetGenericArguments();
            if ( genericArguments != null && genericArguments.Length > 0 )
                return genericArguments[index];

            var interfaces = type.GetInterfaces();
            foreach ( var i in interfaces ) {
                if ( i == typeof( IEnumerable ) ) {
                    genericArguments = i.GetGenericArguments();
                    if ( genericArguments != null && genericArguments.Length > 0 )
                        return genericArguments[index];

                    elementType = i.GetElementType();
                    if ( elementType != null )
                        return elementType;
                }
            }

            return null;
        }

        public static string GetTypeName( Type type, bool fullName = true ) {
            if ( type == null ) return "null";
            if ( type.IsDictionary() ) {
                var kt = type.GetGenericArguments()[0];
                var vt = type.GetGenericArguments()[1];
                return string.Format( "System.Collections.Generic.Dictionary<{0},{1}>", GetTypeName( kt, fullName ), GetTypeName( vt, fullName ) );
            } else if ( type.IsArray() ) {
                var elementType = type.GetElementType();
                return string.Format( "{0}[]", GetTypeName( elementType, fullName ) );
            } else if ( type.IsList() ) {
                try {
                    var elementType = type.GetElementType();
                    if ( elementType == null ) {
                        elementType = type.GetGenericArguments()[0];
                    }
                    return string.Format( "System.Collections.Generic.List<{0}>", GetTypeName( elementType, fullName ) );
                } catch ( Exception ) {
                    return "unknown";
                }
            } else if ( type.IsIEnumerable() ) {
                try {
                    var elementType = type.GetGenericType();
                    return string.Format( "System.Collections.Generic.IEnumerable<{0}>", GetTypeName( elementType, fullName ) );
                } catch ( Exception ) {
                    return "System.Collections.Generic.IEnumerable<?>";
                }
            } else if ( type.IsIList() ) {
                try {
                    var elementType = type.GetGenericType();
                    return string.Format( "System.Collections.Generic.IList<{0}>", GetTypeName( elementType, fullName ) );
                } catch ( Exception ) {
                    return "System.Collections.Generic.IList<?>";
                }
            }

            if ( fullName )
                return type.FullName.Trim( '&' ).Replace( "+", "." );
            else
                return type.Name.Trim( '&' ).Replace( "+", "." );
        }

        public static string GetUniqueFilePath( string directory, string filename, string extension ) {
            extension = extension.Trim().TrimStart( '.' );
            var c = 0;
            var p = Path.Combine( directory, string.Format( "{0}.{1}", filename, extension ) );
            while ( File.Exists( p ) ) {
                c++;
                p = Path.Combine( directory, string.Format( "{0} ({1}).{2}", filename, c, extension ) );
            }
            return p;
        }
    }
}
#endif