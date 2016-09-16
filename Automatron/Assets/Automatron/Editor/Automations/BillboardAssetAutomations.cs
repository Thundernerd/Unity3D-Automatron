using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Billboard Asset/Get Width" )]
	class BillboardAssetwidthGet0 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.width;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Set Width" )]
	class BillboardAssetwidthSet0 : Automation {

		public UnityEngine.BillboardAsset Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.width = Value;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Height" )]
	class BillboardAssetheightGet1 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Set Height" )]
	class BillboardAssetheightSet1 : Automation {

		public UnityEngine.BillboardAsset Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Bottom" )]
	class BillboardAssetbottomGet2 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.bottom;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Set Bottom" )]
	class BillboardAssetbottomSet2 : Automation {

		public UnityEngine.BillboardAsset Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.bottom = Value;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Image Count" )]
	class BillboardAssetimageCountGet3 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.imageCount;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Vertex Count" )]
	class BillboardAssetvertexCountGet4 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.vertexCount;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Index Count" )]
	class BillboardAssetindexCountGet5 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.indexCount;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Get Material" )]
	class BillboardAssetmaterialGet6 : Automation {

		public UnityEngine.BillboardAsset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Billboard Asset/Set Material" )]
	class BillboardAssetmaterialSet6 : Automation {

		public UnityEngine.BillboardAsset Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
