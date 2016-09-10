using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Canvas Group/Get Alpha" )]
	class CanvasGroupalphaGet0 : Automation {

		public UnityEngine.CanvasGroup Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.alpha;
			yield break;
		}

	}

	[Automation( "Canvas Group/Set Alpha" )]
	class CanvasGroupalphaSet0 : Automation {

		public UnityEngine.CanvasGroup Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.alpha = Value;
			yield break;
		}

	}

	[Automation( "Canvas Group/Get Interactable" )]
	class CanvasGroupinteractableGet1 : ConditionalAutomation {

		public UnityEngine.CanvasGroup Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.interactable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Group/Set Interactable" )]
	class CanvasGroupinteractableSet1 : Automation {

		public UnityEngine.CanvasGroup Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.interactable = Value;
			yield break;
		}

	}

	[Automation( "Canvas Group/Get Blocks Raycasts" )]
	class CanvasGroupblocksRaycastsGet2 : ConditionalAutomation {

		public UnityEngine.CanvasGroup Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.blocksRaycasts;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Group/Set Blocks Raycasts" )]
	class CanvasGroupblocksRaycastsSet2 : Automation {

		public UnityEngine.CanvasGroup Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.blocksRaycasts = Value;
			yield break;
		}

	}

	[Automation( "Canvas Group/Get Ignore Parent Groups" )]
	class CanvasGroupignoreParentGroupsGet3 : ConditionalAutomation {

		public UnityEngine.CanvasGroup Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.ignoreParentGroups;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Group/Set Ignore Parent Groups" )]
	class CanvasGroupignoreParentGroupsSet3 : Automation {

		public UnityEngine.CanvasGroup Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.ignoreParentGroups = Value;
			yield break;
		}

	}

	[Automation( "Canvas Group/Is Raycast Location Valid" )]
	class CanvasGroupIsRaycastLocationValid0 : ConditionalAutomation {

		public UnityEngine.CanvasGroup Instance;
		public UnityEngine.Vector2 sp;
		public UnityEngine.Camera eventCamera;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsRaycastLocationValid(sp,eventCamera);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
