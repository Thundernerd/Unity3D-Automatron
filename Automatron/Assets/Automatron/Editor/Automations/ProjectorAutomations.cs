using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Projector/Get Near Clip Plane" )]
	class ProjectornearClipPlaneGet0 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.nearClipPlane;
			yield break;
		}

	}

	[Automation( "Projector/Set Near Clip Plane" )]
	class ProjectornearClipPlaneSet0 : Automation {

		public UnityEngine.Projector Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.nearClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Far Clip Plane" )]
	class ProjectorfarClipPlaneGet1 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.farClipPlane;
			yield break;
		}

	}

	[Automation( "Projector/Set Far Clip Plane" )]
	class ProjectorfarClipPlaneSet1 : Automation {

		public UnityEngine.Projector Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.farClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Field Of View" )]
	class ProjectorfieldOfViewGet2 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fieldOfView;
			yield break;
		}

	}

	[Automation( "Projector/Set Field Of View" )]
	class ProjectorfieldOfViewSet2 : Automation {

		public UnityEngine.Projector Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fieldOfView = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Aspect Ratio" )]
	class ProjectoraspectRatioGet3 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.aspectRatio;
			yield break;
		}

	}

	[Automation( "Projector/Set Aspect Ratio" )]
	class ProjectoraspectRatioSet3 : Automation {

		public UnityEngine.Projector Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.aspectRatio = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Orthographic" )]
	class ProjectororthographicGet4 : ConditionalAutomation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.orthographic;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Projector/Set Orthographic" )]
	class ProjectororthographicSet4 : Automation {

		public UnityEngine.Projector Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.orthographic = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Orthographic Size" )]
	class ProjectororthographicSizeGet5 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.orthographicSize;
			yield break;
		}

	}

	[Automation( "Projector/Set Orthographic Size" )]
	class ProjectororthographicSizeSet5 : Automation {

		public UnityEngine.Projector Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.orthographicSize = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Ignore Layers" )]
	class ProjectorignoreLayersGet6 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.ignoreLayers;
			yield break;
		}

	}

	[Automation( "Projector/Set Ignore Layers" )]
	class ProjectorignoreLayersSet6 : Automation {

		public UnityEngine.Projector Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.ignoreLayers = Value;
			yield break;
		}

	}

	[Automation( "Projector/Get Material" )]
	class ProjectormaterialGet7 : Automation {

		public UnityEngine.Projector Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Projector/Set Material" )]
	class ProjectormaterialSet7 : Automation {

		public UnityEngine.Projector Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
