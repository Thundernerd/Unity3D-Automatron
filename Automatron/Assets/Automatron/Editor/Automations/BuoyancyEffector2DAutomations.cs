using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Buoyancy Effector 2D/Get Surface Level" )]
	class BuoyancyEffector2DsurfaceLevelGet0 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.surfaceLevel;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Surface Level" )]
	class BuoyancyEffector2DsurfaceLevelSet0 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.surfaceLevel = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Density" )]
	class BuoyancyEffector2DdensityGet1 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.density;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Density" )]
	class BuoyancyEffector2DdensitySet1 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.density = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Linear Drag" )]
	class BuoyancyEffector2DlinearDragGet2 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.linearDrag;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Linear Drag" )]
	class BuoyancyEffector2DlinearDragSet2 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.linearDrag = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Angular Drag" )]
	class BuoyancyEffector2DangularDragGet3 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularDrag;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Angular Drag" )]
	class BuoyancyEffector2DangularDragSet3 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularDrag = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Flow Angle" )]
	class BuoyancyEffector2DflowAngleGet4 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.flowAngle;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Flow Angle" )]
	class BuoyancyEffector2DflowAngleSet4 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.flowAngle = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Flow Magnitude" )]
	class BuoyancyEffector2DflowMagnitudeGet5 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.flowMagnitude;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Flow Magnitude" )]
	class BuoyancyEffector2DflowMagnitudeSet5 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.flowMagnitude = Value;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Get Flow Variation" )]
	class BuoyancyEffector2DflowVariationGet6 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.flowVariation;
			yield break;
		}

	}

	[Automation( "Buoyancy Effector 2D/Set Flow Variation" )]
	class BuoyancyEffector2DflowVariationSet6 : Automation {

		public UnityEngine.BuoyancyEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.flowVariation = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
