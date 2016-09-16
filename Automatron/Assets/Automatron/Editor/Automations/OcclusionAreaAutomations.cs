using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Occlusion Area/Get Center" )]
	class OcclusionAreacenterGet0 : Automation {

		public UnityEngine.OcclusionArea Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Occlusion Area/Set Center" )]
	class OcclusionAreacenterSet0 : Automation {

		public UnityEngine.OcclusionArea Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Occlusion Area/Get Size" )]
	class OcclusionAreasizeGet1 : Automation {

		public UnityEngine.OcclusionArea Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Occlusion Area/Set Size" )]
	class OcclusionAreasizeSet1 : Automation {

		public UnityEngine.OcclusionArea Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
