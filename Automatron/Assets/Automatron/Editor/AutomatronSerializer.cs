using System.Collections.Generic;
using System.IO;
using TNRD.Editor.Serialization;
using UnityEngine;

namespace TNRD.Automatron {

    public class SerializableAutomatron {
        public string Name;
        public string EntryID;
        public Vector2 Camera;
        public int ControlID;

        public List<SerializableAutomation> Automations = new List<SerializableAutomation>();
        public List<SerializableLine> Lines = new List<SerializableLine>();
    }

    public class SerializableAutomation {
        public string ID;
        public string Type;
        public Vector2 Position;
    }

    public class SerializableLine {
        public string ID;
        public string IdLeft;
        public string IdRight;
        public ELineType LineType;
    }

    public enum ELineType {
        AutomationLine,
        FieldLine,
        ConditionalLine
    }

    public class AutomatronSerializer {

        public static SerializableAutomatron Load( string path ) {
            if ( !File.Exists( path ) ) {
                return null;
            }

            var b64 = File.ReadAllText( path );
            try {
                var automatron = Deserializer.Deserialize<SerializableAutomatron>( b64 );
                return automatron;
            } catch ( System.Exception ) {
                return null;
            }
        }

        public static void Save( AutomatronEditor editor ) {
            var automatron = new SerializableAutomatron();
            automatron.EntryID = editor.EntryId;
            automatron.Name = editor.Name;
            automatron.Camera = Globals.Camera;
            automatron.ControlID = editor.GetControlID();

            var automations = editor.GetControls<Automation>();
            foreach ( var item in automations ) {
                var automation = new SerializableAutomation();
                automation.ID = item.ID;
                automation.Type = item.GetType().FullName;
                automation.Position = item.Position;
                automatron.Automations.Add( automation );
            }

            var lines = editor.GetControls<BezierLine>();
            foreach ( var item in lines ) {
                var line = new SerializableLine();
                line.ID = item.ID;
                line.IdLeft = ( (AutomationLine)item ).Left.ID;
                line.IdRight = ( (AutomationLine)item ).Right.ID;

                if ( item is ConditionalLine ) {
                    line.LineType = ELineType.ConditionalLine;
                } else if ( item is FieldLine ) {
                    line.LineType = ELineType.FieldLine;
                } else if ( item is AutomationLine ) {
                    line.LineType = ELineType.AutomationLine;
                }

                automatron.Lines.Add( line );
            }

            var b64 = Serializer.SerializeToB64( automatron );

            var path = editor.Path;
            if ( !Directory.Exists( path ) ) {
                Directory.CreateDirectory( path );
            }

            var fpath = Path.Combine( path, automatron.Name + ".acfg" );
            File.WriteAllText( fpath, b64 );
        }
    }
}