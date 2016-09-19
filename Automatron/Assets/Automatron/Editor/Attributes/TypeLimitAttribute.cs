#if UNITY_EDITOR
﻿using System;

namespace TNRD.Automatron {

    [AttributeUsage( AttributeTargets.Field, Inherited = false, AllowMultiple = false )]
    public sealed class TypeLimitAttribute : Attribute {

        public Type Type;

        /// <summary>
        /// Limits the Type popup to types only of this type
        /// </summary>
        public TypeLimitAttribute( Type typeLimit ) {
            Type = typeLimit;
        }
    }
}
#endif