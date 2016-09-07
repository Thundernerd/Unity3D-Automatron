using UnityEngine;
using UnityEditor;
using System;

namespace TNRD.Automatron {

    public struct SimpleDateTime {
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public int Second;

        public static implicit operator SimpleDateTime( DateTime value ) {
            var dt = new SimpleDateTime();
            dt.Year = value.Year;
            dt.Month = value.Month;
            dt.Day = value.Day;
            dt.Hour = value.Hour;
            dt.Minute = value.Minute;
            dt.Second = value.Second;
            return dt;
        }

        public static bool operator ==( SimpleDateTime a, SimpleDateTime b ) {
            return a.Year == b.Year &&
                a.Month == b.Month &&
                a.Day == b.Day &&
                a.Hour == b.Hour &&
                a.Minute == b.Minute &&
                a.Second == b.Second;
        }

        public static bool operator !=( SimpleDateTime a, SimpleDateTime b ) {
            return a.Year != b.Year ||
                a.Month != b.Month ||
                a.Day != b.Day ||
                a.Hour != b.Hour ||
                a.Minute != b.Minute ||
                a.Second != b.Second;
        }

        public DayOfWeek DayOfWeek {
            get {
                return ToDateTime().DayOfWeek;
            }
        }

        public DateTime ToDateTime() {
            return new DateTime( Year, Month, Day, Hour, Minute, Second );
        }

        public override bool Equals( object obj ) {
            return base.Equals( obj );
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }

    public class DatePopup : EditorWindow {

        public static void Show( Rect fieldRect, DateTime value, Action<DateTime> onValueUpdate ) {
            Event.current.Use();
            var popup = CreateInstance<DatePopup>();
            popup.onUpdate = onValueUpdate;
            popup.Initialize( fieldRect, value );
        }

        private Action<DateTime> onUpdate;

        private bool initializedGUI = false;
        private GUIStyle dayStyle;
        private GUIStyle numberStyle;
        private GUIStyle darkNumberStyle;

        private DateTime current;
        private int year {
            get { return current.Year; }
        }
        private int month {
            get { return current.Month; }
        }
        private int day {
            get { return current.Day; }
        }

        private string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private void Initialize( Rect rect, DateTime value ) {
            rect.position = GUIUtility.GUIToScreenPoint( rect.position );
            position = rect;
            current = value;
            wantsMouseMove = true;
            ShowAsDropDown( rect, new Vector2( 218, 290 ) );
            Focus();
        }

        private void InitializeGUI() {
            dayStyle = new GUIStyle( EditorStyles.label );
            dayStyle.alignment = TextAnchor.MiddleCenter;
            dayStyle.fontSize = 16;

            numberStyle = new GUIStyle( EditorStyles.label );
            numberStyle.alignment = TextAnchor.MiddleCenter;
            numberStyle.fontSize = 16;

            numberStyle.hover.background = GetTexture( new Color32( 72, 72, 72, 255 ) );
            numberStyle.hover.textColor = numberStyle.normal.textColor;
            numberStyle.active.background = GetTexture( new Color32( 62, 95, 150, 255 ) );
            numberStyle.active.textColor = numberStyle.normal.textColor;

            darkNumberStyle = new GUIStyle( numberStyle );
            darkNumberStyle.normal.textColor = new Color( 0.43f, 0.43f, 0.43f, 1 );
            darkNumberStyle.hover.textColor = new Color( 0.43f, 0.43f, 0.43f, 1 );
            darkNumberStyle.active.textColor = new Color( 0.43f, 0.43f, 0.43f, 1 );
        }

        private Texture2D GetTexture( Color c ) {
            var tex = new Texture2D( 1, 1, TextureFormat.RGBA32, false );
            tex.hideFlags = HideFlags.HideAndDontSave;

            tex.SetPixel( 0, 0, c );
            tex.Apply();

            return tex;
        }

        private Texture2D GetTexture( Color32 c ) {
            return GetTexture( new Color( c.r / 255f, c.g / 255f, c.b / 255f, c.a / 255f ) );
        }

        private void OnGUI() {
            if ( !initializedGUI ) {
                InitializeGUI();
                initializedGUI = true;
            }

            BeginChangeCheck();
            current = current.AddYears( DrawBoxWithButtons( year.ToString() ) );
            current = current.AddMonths( DrawBoxWithButtons( monthNames[month - 1] ) );

            var startDate = new DateTime( year, month, 1 );
            var startOffset = (int)startDate.DayOfWeek;
            var daysToPrint = new DateTime[42];

            if ( startDate.Year == 1 && startDate.Month == 1 ) {
                startDate = new DateTime( 1, 1, 1 );
            } else {
                startDate = startDate.AddDays( -startOffset );
            }

            for ( int i = 0; i < 42; i++ ) {
                daysToPrint[i] = startDate.AddDays( i ).Add( current.TimeOfDay );
            }

            EditorGUILayout.Space();

            DrawDaysBox();

            var rect = EditorGUILayout.GetControlRect( GUILayout.Height( 180 ) );
            rect.width = 30;
            rect.height = 30;

            for ( int row = 0; row < 6; row++ ) {
                rect.x = 4;
                for ( int column = 0; column < 7; column++ ) {
                    var index = column + 1 + row * 7;
                    var now = daysToPrint[index - 1];
                    var label = now.Day.ToString();
                    var hover = rect.Contains( Event.current.mousePosition );
                    var isDay = ( now.Year == current.Year ) && ( now.Month == current.Month ) && ( now.Day == current.Day );
                    var isMonth = now.Month == current.Month;
                    if ( Event.current.type == EventType.Repaint )
                        ( isMonth ? numberStyle : darkNumberStyle ).Draw( rect, new GUIContent( label ), hover || isDay, isDay, false, false );
                    if ( hover && Event.current.type == EventType.MouseDown && Event.current.button == 0 )
                        current = now;
                    rect.x += 30;
                }
                rect.y += 30;
            }

            if ( EndChangeCheck() ) {
                onUpdate.Invoke( current );
            }

            Repaint();
        }

        private void DrawDaysBox() {
            var rect = EditorGUILayout.GetControlRect( GUILayout.Height( 30 ) );
            rect.width = 30;
            var days = new string[] { "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" };
            for ( int i = 0; i < 7; i++ ) {
                EditorGUI.LabelField( rect, days[i], dayStyle );
                rect.x += 30;
            }
        }

        private int DrawBoxWithButtons( string label ) {
            var value = 0;

            var rect = EditorGUILayout.GetControlRect( GUILayout.Width( position.width - 4 ), GUILayout.Height( 30 ) );
            var w = rect.width;
            rect.width = 30;
            var hover = rect.Contains( Event.current.mousePosition );
            if ( Event.current.type == EventType.Repaint )
                numberStyle.Draw( rect, "<", hover, false, false, false );
            if ( hover && Event.current.type == EventType.MouseDown && Event.current.button == 0 )
                value = -1;
            rect.width = w;

            if ( Event.current.type == EventType.Repaint )
                numberStyle.Draw( rect, label, false, false, false, false );

            rect.x = rect.width - 30;
            rect.width = 30;
            hover = rect.Contains( Event.current.mousePosition );
            if ( Event.current.type == EventType.Repaint )
                numberStyle.Draw( rect, ">", hover, false, false, false );
            if ( hover && Event.current.type == EventType.MouseDown && Event.current.button == 0 )
                value = 1;

            return value;
        }

        private DateTime previous;
        private void BeginChangeCheck() {
            previous = current;
        }

        private bool EndChangeCheck() {
            return current != previous;
        }
    }

    public class TimePopup : EditorWindow {

        public static void Show( Rect fieldRect, DateTime value, Action<DateTime> onValueUpdate ) {
            Event.current.Use();
            var popup = CreateInstance<TimePopup>();
            popup.onUpdate = onValueUpdate;
            popup.Initialize( fieldRect, value );
        }

        private Action<DateTime> onUpdate;

        private bool initializedGUI = false;
        private GUIStyle numberStyle;
        private GUIStyle textStyle;
        private GUIStyle hourStyle;
        private GUIStyle minuteStyle;

        private SimpleDateTime current;
        private bool isAm = true;
        private bool isHours = true;

        private void Initialize( Rect rect, DateTime value ) {
            rect.position = GUIUtility.GUIToScreenPoint( rect.position );
            position = rect;
            current = value;
            isAm = value.Hour < 12;
            wantsMouseMove = true;
            ShowAsDropDown( rect, new Vector2( 210, 260 ) );
            Focus();
        }

        private void InitializeGUI() {

            numberStyle = new GUIStyle( EditorStyles.label );
            numberStyle.alignment = TextAnchor.MiddleCenter;
            numberStyle.clipping = TextClipping.Overflow;
            numberStyle.fontSize = 16;

            numberStyle.normal.background = GetTexture( new Color32( 49, 49, 49, 255 ) );
            numberStyle.hover.background = GetTexture( new Color32( 72, 72, 72, 255 ) );
            numberStyle.hover.textColor = numberStyle.normal.textColor;
            numberStyle.active.background = GetTexture( new Color32( 62, 95, 150, 255 ) );
            numberStyle.active.textColor = numberStyle.normal.textColor;

            textStyle = new GUIStyle( EditorStyles.label );
            textStyle.alignment = TextAnchor.MiddleCenter;
            textStyle.fontSize = 24;
            textStyle.normal.textColor = new Color( 0.43f, 0.43f, 0.43f, 1 );
            textStyle.active.textColor = new Color( 62f / 255, 95f / 255, 150f / 255, 1 );

            hourStyle = new GUIStyle( textStyle );
            hourStyle.alignment = TextAnchor.MiddleRight;

            minuteStyle = new GUIStyle( textStyle );
            minuteStyle.alignment = TextAnchor.MiddleLeft;
        }

        private Texture2D GetTexture( Color c ) {
            var tex = new Texture2D( 1, 1, TextureFormat.RGBA32, false );
            tex.hideFlags = HideFlags.HideAndDontSave;

            tex.SetPixel( 0, 0, c );
            tex.Apply();

            return tex;
        }

        private Texture2D GetTexture( Color32 c ) {
            return GetTexture( new Color( c.r / 255f, c.g / 255f, c.b / 255f, c.a / 255f ) );
        }

        private void OnGUI() {
            if ( !initializedGUI ) {
                InitializeGUI();
                initializedGUI = true;
            }

            DrawTime();

            BeginChangeCheck();

            if ( isHours ) {
                DrawHours();
            } else {
                DrawMinutes();
            }

            if ( EndChangeCheck() ) {
                onUpdate.Invoke( current.ToDateTime() );
            }

            Repaint();
        }

        private void DrawTime() {
            var e = Event.current;
            var hrect = new Rect( 0, 0, position.width / 2 - 5, 50 );
            var mrect = new Rect( position.width / 2 + 5, 0, position.width / 2 - 5, 50 );

            if ( e.type == EventType.Repaint ) {
                var rect = new Rect( 0, 0, position.width, 50 );
                textStyle.Draw( rect, ":", false, false, false, false );
                hourStyle.Draw( hrect, current.Hour.ToString( "00" ), false, false, isHours, isHours );
                minuteStyle.Draw( mrect, current.Minute.ToString( "00" ), false, false, !isHours, !isHours );
            }

            if ( e.type == EventType.MouseDown && e.button == 0 ) {
                if ( hrect.Contains( e.mousePosition ) ) {
                    isHours = true;
                } else if ( mrect.Contains( e.mousePosition ) ) {
                    isHours = false;
                }
            }
        }

        private void DrawHours() {
            var e = Event.current;
            var s = position.width * .4f;
            var c = new Vector2( position.width / 2 - 15, position.height / 2 );

            for ( int i = 0; i < 12; i++ ) {
                var angle = 360 / 12f * i;
                var rad = Mathf.Deg2Rad * ( angle - 90 );
                var pos = new Vector2( Mathf.Cos( rad ), Mathf.Sin( rad ) );
                var npos = c + pos.normalized * s;
                var r = new Rect( npos, new Vector2( 30, 30 ) );
                var l = isAm ? i.ToString() : ( i + 12 ).ToString();
                var isHover = r.Contains( e.mousePosition );
                var isActive = false;

                if ( l == current.Hour.ToString() ) {
                    isActive = true;
                    Handles.BeginGUI();
                    var p = new Vector2( position.width / 2, position.height / 2 + 15 );
                    Handles.DrawAAPolyLine( p, p + pos.normalized * s );
                    Handles.EndGUI();
                }

                if ( e.type == EventType.Repaint )
                    numberStyle.Draw( r, l, ( isHover || isActive ), isActive, false, false );
                if ( ( e.type == EventType.MouseDown || e.type == EventType.MouseDrag ) && e.button == 0 && isHover )
                    current.Hour = isAm ? i : ( i + 12 ) % 24;
            }

            var amRect = new Rect( 10, position.height - 40, 30, 30 );
            var hoverAm = amRect.Contains( e.mousePosition );
            var pmRect = new Rect( position.width - 40, position.height - 40, 30, 30 );
            var hoverPm = pmRect.Contains( e.mousePosition );

            if ( e.type == EventType.Repaint ) {
                numberStyle.Draw( amRect, "am", ( isAm || hoverAm ), isAm, false, false );
                numberStyle.Draw( pmRect, "pm", ( !isAm || hoverPm ), !isAm, false, false );
            }

            if ( e.type == EventType.MouseDown && e.button == 0 ) {
                if ( hoverAm ) {
                    isAm = true;
                    current.Hour = current.Hour == 0 ? 12 : current.Hour - 12;
                } else if ( hoverPm ) {
                    isAm = false;
                    current.Hour = current.Hour == 12 ? 0 : current.Hour + 12;
                }
            }
        }

        private void DrawMinutes() {
            var e = Event.current;
            var s = position.width * .4f;
            var c = new Vector2( position.width / 2 - 15, position.height / 2 );

            for ( int i = 0; i < 60; i++ ) {
                var angle = 360 / 60f * i;
                var rad = Mathf.Deg2Rad * ( angle - 90 );
                var pos = new Vector2( Mathf.Cos( rad ), Mathf.Sin( rad ) );
                var npos = c + pos.normalized * s;
                var r = new Rect( npos, new Vector2( 30, 30 ) );
                var r2 = new Rect( npos, new Vector2( 15, 15 ) );
                r2.x += 7.5f;
                r2.y += 7.5f;
                if ( e.type == EventType.Repaint && i % 5 == 0 )
                    numberStyle.Draw( r, i.ToString(), false, false, false, false );

                if ( i.ToString() == current.Minute.ToString() ) {
                    Handles.BeginGUI();
                    var p = new Vector2( position.width / 2, position.height / 2 + 15 );
                    Handles.DrawAAPolyLine( p, p + pos.normalized * s );
                    Handles.EndGUI();
                }

                if ( ( e.type == EventType.MouseDown || e.type == EventType.MouseDrag ) && e.button == 0 && r2.Contains( e.mousePosition ) )
                    current.Minute = i;
            }

            {
                var angle = 360f / 60f * current.Minute;
                var rad = Mathf.Deg2Rad * ( angle - 90 );
                var pos = new Vector2( Mathf.Cos( rad ), Mathf.Sin( rad ) );
                var npos = c + pos.normalized * s;
                var r = new Rect( npos, new Vector2( 30, 30 ) );
                if ( e.type == EventType.Repaint )
                    numberStyle.Draw( r, current.Minute.ToString(), true, true, false, false );
            }
        }

        private SimpleDateTime previous;
        private void BeginChangeCheck() {
            previous = current;
        }

        private bool EndChangeCheck() {
            return current != previous;
        }
    }
}