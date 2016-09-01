using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Camera/Get Field Of View" )]
	class CamerafieldOfViewGet0 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fieldOfView;
			yield break;
		}

	}

	[Automation( "Camera/Set Field Of View" )]
	class CamerafieldOfViewSet0 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fieldOfView = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Near Clip Plane" )]
	class CameranearClipPlaneGet1 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.nearClipPlane;
			yield break;
		}

	}

	[Automation( "Camera/Set Near Clip Plane" )]
	class CameranearClipPlaneSet1 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.nearClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Far Clip Plane" )]
	class CamerafarClipPlaneGet2 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.farClipPlane;
			yield break;
		}

	}

	[Automation( "Camera/Set Far Clip Plane" )]
	class CamerafarClipPlaneSet2 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.farClipPlane = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Hdr" )]
	class CamerahdrGet3 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hdr;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Hdr" )]
	class CamerahdrSet3 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.hdr = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Orthographic Size" )]
	class CameraorthographicSizeGet4 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.orthographicSize;
			yield break;
		}

	}

	[Automation( "Camera/Set Orthographic Size" )]
	class CameraorthographicSizeSet4 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.orthographicSize = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Orthographic" )]
	class CameraorthographicGet5 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.orthographic;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Orthographic" )]
	class CameraorthographicSet5 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.orthographic = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Opaque Sort Mode" )]
	class CameraopaqueSortModeGet6 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rendering.OpaqueSortMode Result;

		public override IEnumerator Execute() {
			Result = Instance.opaqueSortMode;
			yield break;
		}

	}

	[Automation( "Camera/Set Opaque Sort Mode" )]
	class CameraopaqueSortModeSet6 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rendering.OpaqueSortMode Value;

		public override IEnumerator Execute() {
			Instance.opaqueSortMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Transparency Sort Mode" )]
	class CameratransparencySortModeGet7 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.TransparencySortMode Result;

		public override IEnumerator Execute() {
			Result = Instance.transparencySortMode;
			yield break;
		}

	}

	[Automation( "Camera/Set Transparency Sort Mode" )]
	class CameratransparencySortModeSet7 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.TransparencySortMode Value;

		public override IEnumerator Execute() {
			Instance.transparencySortMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Depth" )]
	class CameradepthGet8 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Camera/Set Depth" )]
	class CameradepthSet8 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.depth = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Aspect" )]
	class CameraaspectGet9 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.aspect;
			yield break;
		}

	}

	[Automation( "Camera/Set Aspect" )]
	class CameraaspectSet9 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.aspect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Culling Mask" )]
	class CameracullingMaskGet10 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMask;
			yield break;
		}

	}

	[Automation( "Camera/Set Culling Mask" )]
	class CameracullingMaskSet10 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.cullingMask = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Event Mask" )]
	class CameraeventMaskGet11 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.eventMask;
			yield break;
		}

	}

	[Automation( "Camera/Set Event Mask" )]
	class CameraeventMaskSet11 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.eventMask = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Background Color" )]
	class CamerabackgroundColorGet12 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.backgroundColor;
			yield break;
		}

	}

	[Automation( "Camera/Set Background Color" )]
	class CamerabackgroundColorSet12 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.backgroundColor = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Rect" )]
	class CamerarectGet13 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.rect;
			yield break;
		}

	}

	[Automation( "Camera/Set Rect" )]
	class CamerarectSet13 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.rect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Rect" )]
	class CamerapixelRectGet14 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelRect;
			yield break;
		}

	}

	[Automation( "Camera/Set Pixel Rect" )]
	class CamerapixelRectSet14 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.pixelRect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Target Texture" )]
	class CameratargetTextureGet15 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.RenderTexture Result;

		public override IEnumerator Execute() {
			Result = Instance.targetTexture;
			yield break;
		}

	}

	[Automation( "Camera/Set Target Texture" )]
	class CameratargetTextureSet15 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.RenderTexture Value;

		public override IEnumerator Execute() {
			Instance.targetTexture = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Width" )]
	class CamerapixelWidthGet16 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelWidth;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Height" )]
	class CamerapixelHeightGet17 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelHeight;
			yield break;
		}

	}

	[Automation( "Camera/Get Camera To World Matrix" )]
	class CameracameraToWorldMatrixGet18 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraToWorldMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Get World To Camera Matrix" )]
	class CameraworldToCameraMatrixGet19 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldToCameraMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set World To Camera Matrix" )]
	class CameraworldToCameraMatrixSet19 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.worldToCameraMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Projection Matrix" )]
	class CameraprojectionMatrixGet20 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set Projection Matrix" )]
	class CameraprojectionMatrixSet20 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.projectionMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Velocity" )]
	class CameravelocityGet21 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Camera/Get Clear Flags" )]
	class CameraclearFlagsGet22 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.CameraClearFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.clearFlags;
			yield break;
		}

	}

	[Automation( "Camera/Set Clear Flags" )]
	class CameraclearFlagsSet22 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.CameraClearFlags Value;

		public override IEnumerator Execute() {
			Instance.clearFlags = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Enabled" )]
	class CamerastereoEnabledGet23 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.stereoEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Get Stereo Separation" )]
	class CamerastereoSeparationGet24 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoSeparation;
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Separation" )]
	class CamerastereoSeparationSet24 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stereoSeparation = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Convergence" )]
	class CamerastereoConvergenceGet25 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoConvergence;
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Convergence" )]
	class CamerastereoConvergenceSet25 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stereoConvergence = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Camera Type" )]
	class CameracameraTypeGet26 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.CameraType Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraType;
			yield break;
		}

	}

	[Automation( "Camera/Set Camera Type" )]
	class CameracameraTypeSet26 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.CameraType Value;

		public override IEnumerator Execute() {
			Instance.cameraType = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Mirror Mode" )]
	class CamerastereoMirrorModeGet27 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.stereoMirrorMode;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Stereo Mirror Mode" )]
	class CamerastereoMirrorModeSet27 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.stereoMirrorMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Target Display" )]
	class CameratargetDisplayGet28 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetDisplay;
			yield break;
		}

	}

	[Automation( "Camera/Set Target Display" )]
	class CameratargetDisplaySet28 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.targetDisplay = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Use Occlusion Culling" )]
	class CamerauseOcclusionCullingGet29 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.useOcclusionCulling;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Use Occlusion Culling" )]
	class CamerauseOcclusionCullingSet29 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useOcclusionCulling = Value;
			yield break;
		}

	}

	[Automation( "Camera/Reset World To Camera Matrix" )]
	class CameraResetWorldToCameraMatrix0 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetWorldToCameraMatrix();
			yield break;
		}

	}

	[Automation( "Camera/Reset Projection Matrix" )]
	class CameraResetProjectionMatrix1 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetProjectionMatrix();
			yield break;
		}

	}

	[Automation( "Camera/Reset Aspect" )]
	class CameraResetAspect2 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetAspect();
			yield break;
		}

	}

	[Automation( "Camera/Reset Field Of View" )]
	class CameraResetFieldOfView3 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetFieldOfView();
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo View Matrices" )]
	class CameraSetStereoViewMatrices4 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 leftMatrix;
		public UnityEngine.Matrix4x4 rightMatrix;

		public override IEnumerator Execute() {
			Instance.SetStereoViewMatrices(leftMatrix,rightMatrix);
			yield break;
		}

	}

	[Automation( "Camera/Reset Stereo View Matrices" )]
	class CameraResetStereoViewMatrices5 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetStereoViewMatrices();
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Projection Matrices" )]
	class CameraSetStereoProjectionMatrices6 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 leftMatrix;
		public UnityEngine.Matrix4x4 rightMatrix;

		public override IEnumerator Execute() {
			Instance.SetStereoProjectionMatrices(leftMatrix,rightMatrix);
			yield break;
		}

	}

	[Automation( "Camera/Reset Stereo Projection Matrices" )]
	class CameraResetStereoProjectionMatrices7 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetStereoProjectionMatrices();
			yield break;
		}

	}

	[Automation( "Camera/World To Screen Point" )]
	class CameraWorldToScreenPoint8 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.WorldToScreenPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/World To Viewport Point" )]
	class CameraWorldToViewportPoint9 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.WorldToViewportPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/Viewport To World Point" )]
	class CameraViewportToWorldPoint10 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ViewportToWorldPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/Screen To World Point" )]
	class CameraScreenToWorldPoint11 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ScreenToWorldPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/Screen To Viewport Point" )]
	class CameraScreenToViewportPoint12 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ScreenToViewportPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/Viewport To Screen Point" )]
	class CameraViewportToScreenPoint13 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ViewportToScreenPoint(position);
			yield break;
		}

	}

	[Automation( "Camera/Viewport Point To Ray" )]
	class CameraViewportPointToRay14 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Ray Result;

		public override IEnumerator Execute() {
			Result = Instance.ViewportPointToRay(position);
			yield break;
		}

	}

	[Automation( "Camera/Screen Point To Ray" )]
	class CameraScreenPointToRay15 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Ray Result;

		public override IEnumerator Execute() {
			Result = Instance.ScreenPointToRay(position);
			yield break;
		}

	}

	[Automation( "Camera/Render" )]
	class CameraRender16 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.Render();
			yield break;
		}

	}

	[Automation( "Camera/Render With Shader" )]
	class CameraRenderWithShader17 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Shader shader;
		public System.String replacementTag;

		public override IEnumerator Execute() {
			Instance.RenderWithShader(shader,replacementTag);
			yield break;
		}

	}

	[Automation( "Camera/Set Replacement Shader" )]
	class CameraSetReplacementShader18 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Shader shader;
		public System.String replacementTag;

		public override IEnumerator Execute() {
			Instance.SetReplacementShader(shader,replacementTag);
			yield break;
		}

	}

	[Automation( "Camera/Reset Replacement Shader" )]
	class CameraResetReplacementShader19 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetReplacementShader();
			yield break;
		}

	}

	[Automation( "Camera/Render Dont Restore" )]
	class CameraRenderDontRestore20 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.RenderDontRestore();
			yield break;
		}

	}

	[Automation( "Camera/Setup Current" )]
	class CameraSetupCurrent21 : Automation {

		public UnityEngine.Camera cur;

		public override IEnumerator Execute() {
			UnityEngine.Camera.SetupCurrent(cur);
			yield break;
		}

	}

	[Automation( "Camera/Copy From" )]
	class CameraCopyFrom22 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera other;

		public override IEnumerator Execute() {
			Instance.CopyFrom(other);
			yield break;
		}

	}

	[Automation( "Camera/Calculate Oblique Matrix" )]
	class CameraCalculateObliqueMatrix23 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Vector4 clipPlane;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.CalculateObliqueMatrix(clipPlane);
			yield break;
		}

	}


#pragma warning restore 0649
}
