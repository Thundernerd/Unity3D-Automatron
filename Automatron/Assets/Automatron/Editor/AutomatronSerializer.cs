using System.Collections.Generic;
using System.IO;
using TNRD.Automatron.Editor.Serialization;
using UnityEngine;

namespace TNRD.Automatron {

    public class SerializableAutomatron {
        public string Name;
        public string Path;
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
        public List<SerializableField> Fields = new List<SerializableField>();
    }

    public class SerializableField {
        public string ID;
        public object Value;
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
        ConditionalLine,
        LoopableLine
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
            automatron.Path = editor.Path;
            automatron.Camera = Globals.Camera;
            automatron.ControlID = editor.GetControlID();

            var automations = editor.GetControls<Automation>();
            foreach ( var item in automations ) {
                var automation = new SerializableAutomation();
                automation.ID = item.ID;
                automation.Type = item.GetType().FullName;
                automation.Position = item.Position;

                var fields = item.GetFields();
                foreach ( var f in fields ) {
                    var field = new SerializableField();
                    field.ID = f.ID;
                    var v = f.GetValue();
                    if ( v is GameObject ) continue;
                    if ( v is ScriptableObject ) continue;
                    field.Value = v;
                    automation.Fields.Add( field );
                }

                automatron.Automations.Add( automation );
            }

            var lines = editor.GetControls<BezierLine>();
            foreach ( var item in lines ) {
                var line = new SerializableLine();
                line.ID = item.ID;

                if ( item is ConditionalLine ) {
                    var l = (ConditionalLine)item;
                    line.LineType = ELineType.ConditionalLine;
                    line.IdLeft = l.Left.ID;
                    line.IdRight = l.Right.ID;
                } else if ( item is FieldLine ) {
                    var l = (FieldLine)item;
                    line.LineType = ELineType.FieldLine;
                    line.IdLeft = l.Left.ID;
                    line.IdRight = l.Right.ID;
                } else if ( item is LoopableLine ) {
                    var l = (LoopableLine)item;
                    line.LineType = ELineType.LoopableLine;
                    line.IdLeft = l.Left.ID;
                    line.IdRight = l.Right.ID;
                } else if ( item is AutomationLine ) {
                    var l = (AutomationLine)item;
                    line.LineType = ELineType.AutomationLine;
                    line.IdLeft = l.Left.ID;
                    line.IdRight = l.Right.ID;
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