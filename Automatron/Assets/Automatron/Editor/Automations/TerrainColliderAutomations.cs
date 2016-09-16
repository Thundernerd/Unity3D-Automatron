using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Terrain Collider/Get Terrain Data" )]
	class TerrainColliderterrainDataGet0 : Automation {

		public UnityEngine.TerrainCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TerrainData Result;

		public override IEnumerator Execute() {
			Result = Instance.terrainData;
			yield break;
		}

	}

	[Automation( "Terrain Collider/Set Terrain Data" )]
	class TerrainColliderterrainDataSet0 : Automation {

		public UnityEngine.TerrainCollider Instance;
		public UnityEngine.TerrainData Value;

		public override IEnumerator Execute() {
			Instance.terrainData = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
