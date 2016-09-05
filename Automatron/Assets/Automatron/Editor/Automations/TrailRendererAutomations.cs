using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rendeders/Trail Renderer/Get Time" )]
	class TrailRenderertimeGet0 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.time;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Set Time" )]
	class TrailRenderertimeSet0 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.time = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Get Start Width" )]
	class TrailRendererstartWidthGet1 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startWidth;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Set Start Width" )]
	class TrailRendererstartWidthSet1 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startWidth = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Get End Width" )]
	class TrailRendererendWidthGet2 : Automation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.endWidth;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Set End Width" )]
	class TrailRendererendWidthSet2 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.endWidth = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Get Autodestruct" )]
	class TrailRendererautodestructGet3 : ConditionalAutomation {

		public UnityEngine.TrailRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.autodestruct;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Trail Renderer/Set Autodestruct" )]
	class TrailRendererautodestructSet3 : Automation {

		public UnityEngine.TrailRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autodestruct = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Trail Renderer/Clear" )]
	class TrailRendererClear0 : Automation {

		public UnityEngine.TrailRenderer Instance;

		public override IEnumerator Execute() {
			Instance.Clear();
			yield break;
		}

	}


#pragma warning restore 0649
}
