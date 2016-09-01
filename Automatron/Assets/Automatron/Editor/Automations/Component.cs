using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Component/Get Game Object" )]
    class ComponentgameObjectGet1 : Automation {

        public UnityEngine.Component Instance;
        [ReadOnly]
        public UnityEngine.GameObject Result;

        public override IEnumerator Execute() {
            Result = Instance.gameObject;
            yield break;
        }

    }

    [Automation( "Component/Get Tag" )]
    class ComponenttagGet2 : Automation {

        public UnityEngine.Component Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.tag;
            yield break;
        }

    }

    [Automation( "Component/Set Tag" )]
    class ComponenttagSet2 : Automation {

        public UnityEngine.Component Instance;
        public System.String Value;

        public override IEnumerator Execute() {
            Instance.tag = Value;
            yield break;
        }

    }

    [Automation( "Component/Get Component By Type" )]
    class ComponentGetComponent0 : Automation {

        public UnityEngine.Component Instance;
        public System.Type type;
        [ReadOnly]
        public UnityEngine.Component Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponent( type );
            yield break;
        }

    }

    [Automation( "Component/Get Component By Name" )]
    class ComponentGetComponent1 : Automation {

        public UnityEngine.Component Instance;
        public System.String type;
        [ReadOnly]
        public UnityEngine.Component Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponent( type );
            yield break;
        }

    }

    [Automation( "Component/Get Component In Children" )]
    class ComponentGetComponentInChildren2 : Automation {

        public UnityEngine.Component Instance;
        public System.Type t;
        public System.Boolean includeInactive;
        [ReadOnly]
        public UnityEngine.Component Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponentInChildren( t, includeInactive );
            yield break;
        }

    }

    [Automation( "Component/Get Components In Children" )]
    class ComponentGetComponentsInChildren5 : Automation {

        public UnityEngine.Component Instance;
        public System.Type t;
        public System.Boolean includeInactive;
        [ReadOnly]
        public UnityEngine.Component[] Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponentsInChildren( t, includeInactive );
            yield break;
        }

    }

    [Automation( "Component/Get Component In Parent" )]
    class ComponentGetComponentInParent6 : Automation {

        public UnityEngine.Component Instance;
        public System.Type t;
        [ReadOnly]
        public UnityEngine.Component Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponentInParent( t );
            yield break;
        }

    }

    [Automation( "Component/Get Components In Parent" )]
    class ComponentGetComponentsInParent8 : Automation {

        public UnityEngine.Component Instance;
        public System.Type t;
        public System.Boolean includeInactive;
        [ReadOnly]
        public UnityEngine.Component[] Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponentsInParent( t, includeInactive );
            yield break;
        }

    }

    [Automation( "Component/Get Components" )]
    class ComponentGetComponents9 : Automation {

        public UnityEngine.Component Instance;
        public System.Type type;
        [ReadOnly]
        public UnityEngine.Component[] Result;

        public override IEnumerator Execute() {
            Result = Instance.GetComponents( type );
            yield break;
        }

    }

    [Automation( "Component/Compare Tag" )]
    class ComponentCompareTag11 : ConditionalAutomation {

        public UnityEngine.Component Instance;
        public System.String tag;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator ExecuteCondition() {
            Result = Instance.CompareTag( tag );
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Component/Get Value By Name" )]
    class ComponentGetValueByName : Automation {

        public UnityEngine.Component Instance;
        public System.String name;
        [ReadOnly]
        public object value;

        public override IEnumerator Execute() {
            var type = Instance.GetType();
            var member = type.GetMember( name, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public );

            if ( member.Length == 1 ) {
                if ( member[0].MemberType == System.Reflection.MemberTypes.Field ) {
                    var field = (System.Reflection.FieldInfo)member[0];
                    value = field.GetValue( Instance );
                } else if ( member[0].MemberType == System.Reflection.MemberTypes.Property ) {
                    var property = (System.Reflection.PropertyInfo)member[0];
                    if ( !property.CanRead ) {
                        throw new System.Exception( string.Format( "Unable to set \"{0}\"", name ) );
                    } else {
                        property.GetValue( Instance, null );
                    }
                } else {
                    throw new System.Exception( string.Format( "\"{0}\" is not a field or property", name ) );
                }
            } else {
                throw new System.Exception( string.Format( "Unable to find member \"{0}\"", name ) );
            }

            yield break;
        }
    }

    [Automation( "Component/Set Value By Name" )]
    class ComponentSetValueByName : Automation {

        public UnityEngine.Component Instance;
        public System.String name;
        public object value;

        public override IEnumerator Execute() {
            var type = Instance.GetType();
            var member = type.GetMember( name, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public );

            if ( member.Length == 1 ) {
                if ( member[0].MemberType == System.Reflection.MemberTypes.Field ) {
                    var field = (System.Reflection.FieldInfo)member[0];
                    field.SetValue( Instance, value );
                } else if ( member[0].MemberType == System.Reflection.MemberTypes.Property ) {
                    var property = (System.Reflection.PropertyInfo)member[0];
                    if ( !property.CanWrite ) {
                        throw new System.Exception( string.Format( "Unable to set \"{0}\"", name ) );
                    } else {
                        property.SetValue( Instance, value, null );
                    }
                } else {
                    throw new System.Exception( string.Format( "\"{0}\" is not a field or property", name ) );
                }
            } else {
                throw new System.Exception( string.Format( "Unable to find member \"{0}\"", name ) );
            }
            
            yield break;
        }
    }


#pragma warning restore 0649
}
