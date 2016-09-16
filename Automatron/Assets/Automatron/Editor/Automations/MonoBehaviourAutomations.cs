using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mono Behaviour/Get Use GUI Layout" )]
	class MonoBehaviouruseGUILayoutGet0 : ConditionalAutomation {

		public UnityEngine.MonoBehaviour Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useGUILayout;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Mono Behaviour/Set Use GUI Layout" )]
	class MonoBehaviouruseGUILayoutSet0 : Automation {

		public UnityEngine.MonoBehaviour Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useGUILayout = Value;
			yield break;
		}

	}

	[Automation( "Mono Behaviour/Invoke" )]
	class MonoBehaviourInvoke0 : Automation {

		public UnityEngine.MonoBehaviour Instance;
		public System.String methodName;
		public System.Single time;

		public override IEnumerator Execute() {
			Instance.Invoke(methodName,time);
			yield break;
		}

	}

	[Automation( "Mono Behaviour/Invoke Repeating" )]
	class MonoBehaviourInvokeRepeating1 : Automation {

		public UnityEngine.MonoBehaviour Instance;
		public System.String methodName;
		public System.Single time;
		public System.Single repeatRate;

		public override IEnumerator Execute() {
			Instance.InvokeRepeating(methodName,time,repeatRate);
			yield break;
		}

	}

	[Automation( "Mono Behaviour/Cancel Invoke" )]
	class MonoBehaviourCancelInvoke2 : Automation {

		public UnityEngine.MonoBehaviour Instance;
		public System.String methodName;

		public override IEnumerator Execute() {
			Instance.CancelInvoke(methodName);
			yield break;
		}

	}

	[Automation( "Mono Behaviour/Is Invoking" )]
	class MonoBehaviourIsInvoking3 : ConditionalAutomation {

		public UnityEngine.MonoBehaviour Instance;
		public System.String methodName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsInvoking(methodName);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
