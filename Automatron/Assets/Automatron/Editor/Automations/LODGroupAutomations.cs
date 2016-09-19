#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "LOD Group/Get Local Reference Point" )]
	class LODGrouplocalReferencePointGet0 : Automation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localReferencePoint;
			yield break;
		}

	}

	[Automation( "LOD Group/Set Local Reference Point" )]
	class LODGrouplocalReferencePointSet0 : Automation {

		public UnityEngine.LODGroup Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localReferencePoint = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Size" )]
	class LODGroupsizeGet1 : Automation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "LOD Group/Set Size" )]
	class LODGroupsizeSet1 : Automation {

		public UnityEngine.LODGroup Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Lod Count" )]
	class LODGrouplodCountGet2 : Automation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.lodCount;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Fade Mode" )]
	class LODGroupfadeModeGet3 : Automation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.LODFadeMode Result;

		public override IEnumerator Execute() {
			Result = Instance.fadeMode;
			yield break;
		}

	}

	[Automation( "LOD Group/Set Fade Mode" )]
	class LODGroupfadeModeSet3 : Automation {

		public UnityEngine.LODGroup Instance;
		public UnityEngine.LODFadeMode Value;

		public override IEnumerator Execute() {
			Instance.fadeMode = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Animate Cross Fading" )]
	class LODGroupanimateCrossFadingGet4 : ConditionalAutomation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.animateCrossFading;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "LOD Group/Set Animate Cross Fading" )]
	class LODGroupanimateCrossFadingSet4 : Automation {

		public UnityEngine.LODGroup Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.animateCrossFading = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Enabled" )]
	class LODGroupenabledGet5 : ConditionalAutomation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "LOD Group/Set Enabled" )]
	class LODGroupenabledSet5 : Automation {

		public UnityEngine.LODGroup Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Get Cross Fade Animation Duration" )]
	class LODGroupcrossFadeAnimationDurationGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.LODGroup.crossFadeAnimationDuration;
			yield break;
		}

	}

	[Automation( "LOD Group/Set Cross Fade Animation Duration" )]
	class LODGroupcrossFadeAnimationDurationSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.LODGroup.crossFadeAnimationDuration = Value;
			yield break;
		}

	}

	[Automation( "LOD Group/Recalculate Bounds" )]
	class LODGroupRecalculateBounds0 : Automation {

		public UnityEngine.LODGroup Instance;

		public override IEnumerator Execute() {
			Instance.RecalculateBounds();
			yield break;
		}

	}

	[Automation( "LOD Group/Get LO Ds" )]
	class LODGroupGetLODs1 : Automation {

		public UnityEngine.LODGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.LOD[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLODs();
			yield break;
		}

	}

	[Automation( "LOD Group/Set LO Ds" )]
	class LODGroupSetLODs2 : Automation {

		public UnityEngine.LODGroup Instance;
		public UnityEngine.LOD[] lods;

		public override IEnumerator Execute() {
			Instance.SetLODs(lods);
			yield break;
		}

	}

	[Automation( "LOD Group/Force LOD" )]
	class LODGroupForceLOD3 : Automation {

		public UnityEngine.LODGroup Instance;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.ForceLOD(index);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif