#if UNITY_EDITOR
﻿using System;

namespace TNRD.Automatron {

    [AttributeUsage( AttributeTargets.Class, Inherited = false, AllowMultiple = false )]
    public sealed class CustomDrawerAttribute : Attribute {

        public Type Type;

        public CustomDrawerAttribute( Type type ) {
            Type = type;
        }
    }
}
#endif