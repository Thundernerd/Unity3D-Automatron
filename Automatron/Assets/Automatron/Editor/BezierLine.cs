using TNRD.Editor.Core;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class BezierLine : ExtendedControl {

        public Vector2 Start;
        public Vector2 End;

        public Vector2 P1;
        public Vector2 P2;

        protected override void OnGUI() {
            Handles.BeginGUI();
            Handles.DrawAAPolyLine( GetBezierPoints( Start, End, P1, P2 ) );
            Handles.EndGUI();
        }

        private Vector3[] GetBezierPoints( Vector2 start, Vector2 end, Vector2 p1, Vector2 p2, int iterations = 25 ) {
            var points = new Vector3[iterations + 1];

            for ( int i = 0; i <= iterations; i++ ) {
                var j = ( (float)i / iterations );

                var ap1 = Vector3.Lerp( start, p1, j );
                var ap2 = Vector3.Lerp( p1, p2, j );
                var ap3 = Vector3.Lerp( p2, end, j );

                var bp1 = Vector3.Lerp( ap1, ap2, j );
                var bp2 = Vector3.Lerp( ap2, ap3, j );

                var p = Vector3.Lerp( bp1, bp2, j );
                points[i] = p;
            }

            return points;
        }
    }
}