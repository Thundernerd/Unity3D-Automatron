using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Network View/Get Observed" )]
	class NetworkViewobservedGet0 : Automation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.observed;
			yield break;
		}

	}

	[Automation( "Network View/Set Observed" )]
	class NetworkViewobservedSet0 : Automation {

		public UnityEngine.NetworkView Instance;
		public UnityEngine.Component Value;

		public override IEnumerator Execute() {
			Instance.observed = Value;
			yield break;
		}

	}

	[Automation( "Network View/Get State Synchronization" )]
	class NetworkViewstateSynchronizationGet1 : Automation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public UnityEngine.NetworkStateSynchronization Result;

		public override IEnumerator Execute() {
			Result = Instance.stateSynchronization;
			yield break;
		}

	}

	[Automation( "Network View/Set State Synchronization" )]
	class NetworkViewstateSynchronizationSet1 : Automation {

		public UnityEngine.NetworkView Instance;
		public UnityEngine.NetworkStateSynchronization Value;

		public override IEnumerator Execute() {
			Instance.stateSynchronization = Value;
			yield break;
		}

	}

	[Automation( "Network View/Get View ID" )]
	class NetworkViewviewIDGet2 : Automation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public UnityEngine.NetworkViewID Result;

		public override IEnumerator Execute() {
			Result = Instance.viewID;
			yield break;
		}

	}

	[Automation( "Network View/Set View ID" )]
	class NetworkViewviewIDSet2 : Automation {

		public UnityEngine.NetworkView Instance;
		public UnityEngine.NetworkViewID Value;

		public override IEnumerator Execute() {
			Instance.viewID = Value;
			yield break;
		}

	}

	[Automation( "Network View/Get Group" )]
	class NetworkViewgroupGet3 : Automation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.group;
			yield break;
		}

	}

	[Automation( "Network View/Set Group" )]
	class NetworkViewgroupSet3 : Automation {

		public UnityEngine.NetworkView Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.group = Value;
			yield break;
		}

	}

	[Automation( "Network View/Get Is Mine" )]
	class NetworkViewisMineGet4 : ConditionalAutomation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isMine;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Network View/Get Owner" )]
	class NetworkViewownerGet5 : Automation {

		public UnityEngine.NetworkView Instance;
		[ReadOnly]
		public UnityEngine.NetworkPlayer Result;

		public override IEnumerator Execute() {
			Result = Instance.owner;
			yield break;
		}

	}

	[Automation( "Network View/Set Scope" )]
	class NetworkViewSetScope0 : ConditionalAutomation {

		public UnityEngine.NetworkView Instance;
		public UnityEngine.NetworkPlayer player;
		public System.Boolean relevancy;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SetScope(player,relevancy);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Network View/Find" )]
	class NetworkViewFind1 : Automation {

		public UnityEngine.NetworkViewID viewID;
		[ReadOnly]
		public UnityEngine.NetworkView Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.NetworkView.Find(viewID);
			yield break;
		}

	}


#pragma warning restore 0649
}
