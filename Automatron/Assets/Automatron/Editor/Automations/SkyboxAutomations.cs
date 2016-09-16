using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Skybox/Get Material" )]
	class SkyboxmaterialGet0 : Automation {

		public UnityEngine.Skybox Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Skybox/Set Material" )]
	class SkyboxmaterialSet0 : Automation {

		public UnityEngine.Skybox Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
