using System;

namespace TNRD.Automatron {

    [AttributeUsage( AttributeTargets.Class, Inherited = false, AllowMultiple = false )]
    sealed class AutomationAttribute : Attribute {

        public string Name;

        public AutomationAttribute() { }

        public AutomationAttribute( string name ) {
            Name = name;
        }
    }
}