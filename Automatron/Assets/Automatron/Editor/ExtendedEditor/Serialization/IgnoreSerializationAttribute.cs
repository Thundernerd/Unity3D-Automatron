#if UNITY_EDITOR
﻿using System;

namespace TNRD.Automatron.Editor.Serialization {

    [AttributeUsage( AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false )]
    public sealed class IgnoreSerializationAttribute : Attribute { }
}
#endif