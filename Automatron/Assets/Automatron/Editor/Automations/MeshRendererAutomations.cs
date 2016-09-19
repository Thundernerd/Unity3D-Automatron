#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mesh Renderer/Get Additional Vertex Streams" )]
	class MeshRendereradditionalVertexStreamsGet0 : Automation {

		public UnityEngine.MeshRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.additionalVertexStreams;
			yield break;
		}

	}

	[Automation( "Mesh Renderer/Set Additional Vertex Streams" )]
	class MeshRendereradditionalVertexStreamsSet0 : Automation {

		public UnityEngine.MeshRenderer Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.additionalVertexStreams = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif