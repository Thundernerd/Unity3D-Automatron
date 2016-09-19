#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Line Renderer/Get Use World Space" )]
	class LineRendereruseWorldSpaceGet0 : ConditionalAutomation {

		public UnityEngine.LineRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useWorldSpace;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Line Renderer/Set Use World Space" )]
	class LineRendereruseWorldSpaceSet0 : Automation {

		public UnityEngine.LineRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useWorldSpace = Value;
			yield break;
		}

	}

	[Automation( "Line Renderer/Set Width" )]
	class LineRendererSetWidth0 : Automation {

		public UnityEngine.LineRenderer Instance;
		public System.Single start;
		public System.Single end;

		public override IEnumerator Execute() {
			Instance.SetWidth(start,end);
			yield break;
		}

	}

	[Automation( "Line Renderer/Set Colors" )]
	class LineRendererSetColors1 : Automation {

		public UnityEngine.LineRenderer Instance;
		public UnityEngine.Color start;
		public UnityEngine.Color end;

		public override IEnumerator Execute() {
			Instance.SetColors(start,end);
			yield break;
		}

	}

	[Automation( "Line Renderer/Set Vertex Count" )]
	class LineRendererSetVertexCount2 : Automation {

		public UnityEngine.LineRenderer Instance;
		public System.Int32 count;

		public override IEnumerator Execute() {
			Instance.SetVertexCount(count);
			yield break;
		}

	}

	[Automation( "Line Renderer/Set Position" )]
	class LineRendererSetPosition3 : Automation {

		public UnityEngine.LineRenderer Instance;
		public System.Int32 index;
		public UnityEngine.Vector3 position;

		public override IEnumerator Execute() {
			Instance.SetPosition(index,position);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif