using System;

namespace TNRD.Automatron {

    [AttributeUsage( AttributeTargets.Class, Inherited = false, AllowMultiple = false )]
    sealed class CustomDrawerAttribute : Attribute {

        public Type Type;

        public CustomDrawerAttribute( Type type ) {
            Type = type;
        }
    }
}