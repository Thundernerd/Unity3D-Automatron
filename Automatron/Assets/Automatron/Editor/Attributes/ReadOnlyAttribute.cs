using System;

namespace TNRD.Automatron {

    [AttributeUsage( AttributeTargets.Field, Inherited = false, AllowMultiple = false )]
    public sealed class ReadOnlyAttribute : Attribute {

        public ReadOnlyAttribute() { }
    }
}