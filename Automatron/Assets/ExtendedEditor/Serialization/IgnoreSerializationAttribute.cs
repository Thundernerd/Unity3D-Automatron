using System;

namespace TNRD.Editor.Serialization {

    [AttributeUsage( AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false )]
    public sealed class IgnoreSerializationAttribute : Attribute { }
}