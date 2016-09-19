#if UNITY_EDITOR
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace TNRD.Automatron {

    public static class Globals {

        public static List<Type> Types;

        public static Vector2 Camera;

        public static bool IsError;
        public static bool IsExecuting;

        public static FieldLine TempFieldLine;
        public static AutomationLine TempAutomationLine;

        public static Exception LastError;
        public static Automation LastAutomation;
    }
}
#endif