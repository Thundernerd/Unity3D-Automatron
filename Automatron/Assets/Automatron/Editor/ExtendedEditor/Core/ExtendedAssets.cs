#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TNRD.Automatron.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Editor.Core {

    public class ExtendedAssets {

        public enum EAssetType {
            Text,
            Texture
        }

        [IgnoreSerialization]
        private Dictionary<string, Texture2D> textures;
        [IgnoreSerialization]
        private Dictionary<string, string> texts;

#if IS_LIBRARY
        private string[] resources;
#endif

        public string Path;

        public Texture2D this[string key] {
            get {
                if ( textures.ContainsKey( key ) ) {
                    return textures[key];
                } else {
                    return Texture( key );
                }
            }
        }

        public ExtendedAssets() {
            textures = new Dictionary<string, Texture2D>();
            texts = new Dictionary<string, string>();

#if IS_LIBRARY
            resources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
#endif
        }

        public void Initialize( string path ) {
            if ( !string.IsNullOrEmpty( path ) ) {
                Path = path;
            } else {
                var stack = new System.Diagnostics.StackTrace( true );
                if ( stack.FrameCount > 0 ) {
                    var frame = stack.GetFrame( stack.FrameCount - 1 );
                    var fname = System.IO.Path.GetFileName( frame.GetFileName() );

                    Path = frame.GetFileName().Replace( '\\', '/' );
                    Path = Path.Replace( fname, "Assets/" );
                }
            }
        }

        private string GetExtension( EAssetType type ) {
            switch ( type ) {
                case EAssetType.Text:
                    return ".txt";
                case EAssetType.Texture:
                    return ".png";
            }

            return "";
        }

        private string GetPath( string key, EAssetType type ) {
#if IS_LIBRARY
            if ( EditorGUIUtility.isProSkin ) {
                return resources.Where( r => r.EndsWith( "pro." + key + GetExtension( type ) ) ).FirstOrDefault();
            } else {
                return resources.Where( r => r.EndsWith( key + GetExtension( type ) ) ).FirstOrDefault();
            }
#else
            if ( EditorGUIUtility.isProSkin ) {
                var pp = System.IO.Path.Combine( System.IO.Path.Combine( Path, "pro" ), key +  GetExtension( type ) );
                if ( File.Exists( pp ) ) {
                    return pp;
                }
            }

            var fp = System.IO.Path.Combine( Path, key + GetExtension( type ) );
            if ( File.Exists( fp ) )
                return fp;
            else
                return "";
#endif
        }

        public Texture2D Texture( string key ) {
            if ( textures.ContainsKey( key ) ) {
                return textures[key];
            }

            var path = GetPath( key, EAssetType.Texture );
            if ( string.IsNullOrEmpty( path ) )
                return null;

            var tex = new Texture2D( 1, 1 );
            tex.hideFlags = HideFlags.HideAndDontSave;

#if IS_LIBRARY
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream( path );
            byte[] bytes;
            using ( var ms = new MemoryStream() ) {
                var buffer = new byte[4096];
                var count = 0;
                while ( (count = stream.Read(buffer, 0, buffer.Length)) != 0 ) {
                    ms.Write( buffer, 0, count );
                }
                bytes = ms.ToArray();
            }
            tex.LoadImage( bytes );
#else
            var bytes = File.ReadAllBytes( path );
            tex.LoadImage( bytes );
#endif

            textures.Add( key, tex );
            return textures[key];
        }

        public string Text( string key ) {
            if ( texts.ContainsKey( key ) ) {
                return texts[key];
            }

            var path = GetPath( key, EAssetType.Text );
            if ( string.IsNullOrEmpty( path ) )
                return "";

#if IS_LIBRARY
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream( path );
            var data = "";
            using ( var reader = new StreamReader( stream ) ) {
                data = reader.ReadToEnd();
            }
            return data;
#else
            var data = File.ReadAllText( path );
            return data;
#endif
        }

        public Texture2D B64( string key, string b64 ) {
            if ( textures.ContainsKey( key ) ) {
                return textures[key];
            }

            var tex = new Texture2D( 1, 1 );
            tex.hideFlags = HideFlags.HideAndDontSave;

            var bytes = System.Convert.FromBase64String( b64 );
            tex.LoadImage( bytes );

            textures.Add( key, tex );
            return textures[key];
        }

        public bool HasKey( string key ) {
            return textures.ContainsKey( key );
        }
    }
}
#endif