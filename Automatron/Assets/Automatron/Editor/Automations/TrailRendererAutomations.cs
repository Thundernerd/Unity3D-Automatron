using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Trail Renderer/Get Time" )]
	class TrailRenderertimeGet0 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.time;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Set Time" )]
	class TrailRenderertimeSet0 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.time = Value;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Get Start Width" )]
	class TrailRendererstartWidthGet1 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startWidth;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Set Start Width" )]
	class TrailRendererstartWidthSet1 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startWidth = Value;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Get End Width" )]
	class TrailRendererendWidthGet2 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.endWidth;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Set End Width" )]
	class TrailRendererendWidthSet2 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.endWidth = Value;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Get Autodestruct" )]
	class TrailRendererautodestructGet3 : ConditionalAutomation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autodestruct;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Trail Renderer/Set Autodestruct" )]
	class TrailRendererautodestructSet3 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autodestruct = Value;
			yield break;
		}

	}

	[Automation( "Trail Renderer/Clear" )]
	class TrailRendererClear0 : Automation {

		public UnityEngine.TrailRenderer Instance;

		public override IEnumerator Execute() {
			Instance.Clear();
			yield break;
		}

	}


#pragma warning restore 0649
}
