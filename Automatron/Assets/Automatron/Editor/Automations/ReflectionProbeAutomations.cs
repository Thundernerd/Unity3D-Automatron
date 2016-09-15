using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Reflection Probe/Get Type" )]
	class ReflectionProbetypeGet0 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeType Result;

		public override IEnumerator Execute() {
			Result = Instance.type;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Type" )]
	class ReflectionProbetypeSet0 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Rendering.ReflectionProbeType Value;

		public override IEnumerator Execute() {
			Instance.type = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Hdr" )]
	class ReflectionProbehdrGet1 : ConditionalAutomation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hdr;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Reflection Probe/Set Hdr" )]
	class ReflectionProbehdrSet1 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.hdr = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Size" )]
	class ReflectionProbesizeGet2 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Size" )]
	class ReflectionProbesizeSet2 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Center" )]
	class ReflectionProbecenterGet3 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Center" )]
	class ReflectionProbecenterSet3 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Near Clip Plane" )]
	class ReflectionProbenearClipPlaneGet4 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.nearClipPlane;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Near Clip Plane" )]
	class ReflectionProbenearClipPlaneSet4 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.nearClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Far Clip Plane" )]
	class ReflectionProbefarClipPlaneGet5 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.farClipPlane;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Far Clip Plane" )]
	class ReflectionProbefarClipPlaneSet5 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.farClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Shadow Distance" )]
	class ReflectionProbeshadowDistanceGet6 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowDistance;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Shadow Distance" )]
	class ReflectionProbeshadowDistanceSet6 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowDistance = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Resolution" )]
	class ReflectionProberesolutionGet7 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.resolution;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Resolution" )]
	class ReflectionProberesolutionSet7 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.resolution = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Culling Mask" )]
	class ReflectionProbecullingMaskGet8 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMask;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Culling Mask" )]
	class ReflectionProbecullingMaskSet8 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.cullingMask = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Clear Flags" )]
	class ReflectionProbeclearFlagsGet9 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeClearFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.clearFlags;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Clear Flags" )]
	class ReflectionProbeclearFlagsSet9 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Rendering.ReflectionProbeClearFlags Value;

		public override IEnumerator Execute() {
			Instance.clearFlags = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Background Color" )]
	class ReflectionProbebackgroundColorGet10 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.backgroundColor;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Background Color" )]
	class ReflectionProbebackgroundColorSet10 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.backgroundColor = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Intensity" )]
	class ReflectionProbeintensityGet11 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.intensity;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Intensity" )]
	class ReflectionProbeintensitySet11 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.intensity = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Blend Distance" )]
	class ReflectionProbeblendDistanceGet12 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.blendDistance;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Blend Distance" )]
	class ReflectionProbeblendDistanceSet12 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.blendDistance = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Box Projection" )]
	class ReflectionProbeboxProjectionGet13 : ConditionalAutomation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.boxProjection;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Reflection Probe/Set Box Projection" )]
	class ReflectionProbeboxProjectionSet13 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.boxProjection = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Bounds" )]
	class ReflectionProbeboundsGet14 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Mode" )]
	class ReflectionProbemodeGet15 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeMode Result;

		public override IEnumerator Execute() {
			Result = Instance.mode;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Mode" )]
	class ReflectionProbemodeSet15 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Rendering.ReflectionProbeMode Value;

		public override IEnumerator Execute() {
			Instance.mode = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Importance" )]
	class ReflectionProbeimportanceGet16 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.importance;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Importance" )]
	class ReflectionProbeimportanceSet16 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.importance = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Refresh Mode" )]
	class ReflectionProberefreshModeGet17 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeRefreshMode Result;

		public override IEnumerator Execute() {
			Result = Instance.refreshMode;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Refresh Mode" )]
	class ReflectionProberefreshModeSet17 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Rendering.ReflectionProbeRefreshMode Value;

		public override IEnumerator Execute() {
			Instance.refreshMode = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Time Slicing Mode" )]
	class ReflectionProbetimeSlicingModeGet18 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.timeSlicingMode;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Time Slicing Mode" )]
	class ReflectionProbetimeSlicingModeSet18 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode Value;

		public override IEnumerator Execute() {
			Instance.timeSlicingMode = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Baked Texture" )]
	class ReflectionProbebakedTextureGet19 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.bakedTexture;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Baked Texture" )]
	class ReflectionProbebakedTextureSet19 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Texture Value;

		public override IEnumerator Execute() {
			Instance.bakedTexture = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Custom Baked Texture" )]
	class ReflectionProbecustomBakedTextureGet20 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.customBakedTexture;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Set Custom Baked Texture" )]
	class ReflectionProbecustomBakedTextureSet20 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.Texture Value;

		public override IEnumerator Execute() {
			Instance.customBakedTexture = Value;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Texture" )]
	class ReflectionProbetextureGet21 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		[ReadOnly]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.texture;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Min Baked Cubemap Resolution" )]
	class ReflectionProbeminBakedCubemapResolutionGet22 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ReflectionProbe.minBakedCubemapResolution;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Get Max Baked Cubemap Resolution" )]
	class ReflectionProbemaxBakedCubemapResolutionGet23 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ReflectionProbe.maxBakedCubemapResolution;
			yield break;
		}

	}

	[Automation( "Reflection Probe/Render Probe" )]
	class ReflectionProbeRenderProbe0 : Automation {

		public UnityEngine.ReflectionProbe Instance;
		public UnityEngine.RenderTexture targetTexture;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.RenderProbe(targetTexture);
			yield break;
		}

	}

	[Automation( "Reflection Probe/Is Finished Rendering" )]
	class ReflectionProbeIsFinishedRendering1 : ConditionalAutomation {

		public UnityEngine.ReflectionProbe Instance;
		public System.Int32 renderId;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsFinishedRendering(renderId);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Reflection Probe/Blend Cubemap" )]
	class ReflectionProbeBlendCubemap2 : ConditionalAutomation {

		public UnityEngine.Texture src;
		public UnityEngine.Texture dst;
		public System.Single blend;
		public UnityEngine.RenderTexture target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ReflectionProbe.BlendCubemap(src,dst,blend,target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
