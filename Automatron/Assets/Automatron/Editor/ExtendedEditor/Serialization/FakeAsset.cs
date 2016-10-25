#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace TNRD.Automatron.Editor.Serialization {

    public class FakeAsset {

        public string Guid;
        public string Type;

        public FakeAsset() { }

        public FakeAsset( string guid ) {
            Guid = guid;
        }

        public FakeAsset( Object obj, out bool result ) {
            var path = AssetDatabase.GetAssetPath( obj );
            if ( string.IsNullOrEmpty( path ) ) {
                result = false;
                return;
            }

            Guid = AssetDatabase.AssetPathToGUID( path );
            if ( string.IsNullOrEmpty( Guid ) ) {
                result = false;
                return;
            }

            Type = obj.GetType().AssemblyQualifiedName;

            var temp = GetValue();
            result = obj == temp;
        }

        public Object GetValue() {
            var type = System.Type.GetType( Type );
            var path = AssetDatabase.GUIDToAssetPath( Guid );
            var obj = AssetDatabase.LoadAssetAtPath( path, type );
            return obj;
        }
    }
}
#endif