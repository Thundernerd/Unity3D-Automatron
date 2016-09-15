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

	[Automation( "Camera/Get Rendering Path" )]
	class CamerarenderingPathGet3 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = Instance.renderingPath;
			yield break;
		}

	}

	[Automation( "Camera/Set Rendering Path" )]
	class CamerarenderingPathSet3 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.RenderingPath Value;

		public override IEnumerator Execute() {
			Instance.renderingPath = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Actual Rendering Path" )]
	class CameraactualRenderingPathGet4 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = Instance.actualRenderingPath;
			yield break;
		}

	}

	[Automation( "Camera/Get Hdr" )]
	class CamerahdrGet5 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
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

	[Automation( "Camera/Set Hdr" )]
	class CamerahdrSet5 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.hdr = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Orthographic Size" )]
	class CameraorthographicSizeGet6 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.orthographicSize;
			yield break;
		}

	}

	[Automation( "Camera/Set Orthographic Size" )]
	class CameraorthographicSizeSet6 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.orthographicSize = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Orthographic" )]
	class CameraorthographicGet7 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.orthographic;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Orthographic" )]
	class CameraorthographicSet7 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.orthographic = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Opaque Sort Mode" )]
	class CameraopaqueSortModeGet8 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rendering.OpaqueSortMode Result;

		public override IEnumerator Execute() {
			Result = Instance.opaqueSortMode;
			yield break;
		}

	}

	[Automation( "Camera/Set Opaque Sort Mode" )]
	class CameraopaqueSortModeSet8 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rendering.OpaqueSortMode Value;

		public override IEnumerator Execute() {
			Instance.opaqueSortMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Transparency Sort Mode" )]
	class CameratransparencySortModeGet9 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.TransparencySortMode Result;

		public override IEnumerator Execute() {
			Result = Instance.transparencySortMode;
			yield break;
		}

	}

	[Automation( "Camera/Set Transparency Sort Mode" )]
	class CameratransparencySortModeSet9 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.TransparencySortMode Value;

		public override IEnumerator Execute() {
			Instance.transparencySortMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Depth" )]
	class CameradepthGet10 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Camera/Set Depth" )]
	class CameradepthSet10 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.depth = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Aspect" )]
	class CameraaspectGet11 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.aspect;
			yield break;
		}

	}

	[Automation( "Camera/Set Aspect" )]
	class CameraaspectSet11 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.aspect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Culling Mask" )]
	class CameracullingMaskGet12 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMask;
			yield break;
		}

	}

	[Automation( "Camera/Set Culling Mask" )]
	class CameracullingMaskSet12 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.cullingMask = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Event Mask" )]
	class CameraeventMaskGet13 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.eventMask;
			yield break;
		}

	}

	[Automation( "Camera/Set Event Mask" )]
	class CameraeventMaskSet13 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.eventMask = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Background Color" )]
	class CamerabackgroundColorGet14 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.backgroundColor;
			yield break;
		}

	}

	[Automation( "Camera/Set Background Color" )]
	class CamerabackgroundColorSet14 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.backgroundColor = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Rect" )]
	class CamerarectGet15 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.rect;
			yield break;
		}

	}

	[Automation( "Camera/Set Rect" )]
	class CamerarectSet15 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.rect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Rect" )]
	class CamerapixelRectGet16 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelRect;
			yield break;
		}

	}

	[Automation( "Camera/Set Pixel Rect" )]
	class CamerapixelRectSet16 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.pixelRect = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Target Texture" )]
	class CameratargetTextureGet17 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.RenderTexture Result;

		public override IEnumerator Execute() {
			Result = Instance.targetTexture;
			yield break;
		}

	}

	[Automation( "Camera/Set Target Texture" )]
	class CameratargetTextureSet17 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.RenderTexture Value;

		public override IEnumerator Execute() {
			Instance.targetTexture = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Width" )]
	class CamerapixelWidthGet18 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelWidth;
			yield break;
		}

	}

	[Automation( "Camera/Get Pixel Height" )]
	class CamerapixelHeightGet19 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelHeight;
			yield break;
		}

	}

	[Automation( "Camera/Get Camera To World Matrix" )]
	class CameracameraToWorldMatrixGet20 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraToWorldMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Get World To Camera Matrix" )]
	class CameraworldToCameraMatrixGet21 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldToCameraMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set World To Camera Matrix" )]
	class CameraworldToCameraMatrixSet21 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.worldToCameraMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Projection Matrix" )]
	class CameraprojectionMatrixGet22 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set Projection Matrix" )]
	class CameraprojectionMatrixSet22 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.projectionMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Non Jittered Projection Matrix" )]
	class CameranonJitteredProjectionMatrixGet23 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.nonJitteredProjectionMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set Non Jittered Projection Matrix" )]
	class CameranonJitteredProjectionMatrixSet23 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.nonJitteredProjectionMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Velocity" )]
	class CameravelocityGet24 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Camera/Get Clear Flags" )]
	class CameraclearFlagsGet25 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.CameraClearFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.clearFlags;
			yield break;
		}

	}

	[Automation( "Camera/Set Clear Flags" )]
	class CameraclearFlagsSet25 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.CameraClearFlags Value;

		public override IEnumerator Execute() {
			Instance.clearFlags = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Enabled" )]
	class CamerastereoEnabledGet26 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Get Stereo Separation" )]
	class CamerastereoSeparationGet27 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoSeparation;
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Separation" )]
	class CamerastereoSeparationSet27 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stereoSeparation = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Convergence" )]
	class CamerastereoConvergenceGet28 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoConvergence;
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Convergence" )]
	class CamerastereoConvergenceSet28 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stereoConvergence = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Camera Type" )]
	class CameracameraTypeGet29 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.CameraType Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraType;
			yield break;
		}

	}

	[Automation( "Camera/Set Camera Type" )]
	class CameracameraTypeSet29 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.CameraType Value;

		public override IEnumerator Execute() {
			Instance.cameraType = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Mirror Mode" )]
	class CamerastereoMirrorModeGet30 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoMirrorMode;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Stereo Mirror Mode" )]
	class CamerastereoMirrorModeSet30 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.stereoMirrorMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Target Eye" )]
	class CamerastereoTargetEyeGet31 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.StereoTargetEyeMask Result;

		public override IEnumerator Execute() {
			Result = Instance.stereoTargetEye;
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Target Eye" )]
	class CamerastereoTargetEyeSet31 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.StereoTargetEyeMask Value;

		public override IEnumerator Execute() {
			Instance.stereoTargetEye = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Target Display" )]
	class CameratargetDisplayGet32 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetDisplay;
			yield break;
		}

	}

	[Automation( "Camera/Set Target Display" )]
	class CameratargetDisplaySet32 : Automation {

		public UnityEngine.Camera Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.targetDisplay = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Main" )]
	class CameramainGet33 : Automation {

		[ReadOnly]
		public UnityEngine.Camera Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Camera.main;
			yield break;
		}

	}

	[Automation( "Camera/Get Current" )]
	class CameracurrentGet34 : Automation {

		[ReadOnly]
		public UnityEngine.Camera Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Camera.current;
			yield break;
		}

	}

	[Automation( "Camera/Get All Cameras" )]
	class CameraallCamerasGet35 : Automation {

		[ReadOnly]
		public UnityEngine.Camera[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Camera.allCameras;
			yield break;
		}

	}

	[Automation( "Camera/Get All Cameras Count" )]
	class CameraallCamerasCountGet36 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Camera.allCamerasCount;
			yield break;
		}

	}

	[Automation( "Camera/Get Use Occlusion Culling" )]
	class CamerauseOcclusionCullingGet37 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useOcclusionCulling;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Use Occlusion Culling" )]
	class CamerauseOcclusionCullingSet37 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useOcclusionCulling = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Culling Matrix" )]
	class CameracullingMatrixGet38 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMatrix;
			yield break;
		}

	}

	[Automation( "Camera/Set Culling Matrix" )]
	class CameracullingMatrixSet38 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 Value;

		public override IEnumerator Execute() {
			Instance.cullingMatrix = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Layer Cull Distances" )]
	class CameralayerCullDistancesGet39 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Single[] Result;

		public override IEnumerator Execute() {
			Result = Instance.layerCullDistances;
			yield break;
		}

	}

	[Automation( "Camera/Set Layer Cull Distances" )]
	class CameralayerCullDistancesSet39 : Automation {

		public UnityEngine.Camera Instance;
		public System.Single[] Value;

		public override IEnumerator Execute() {
			Instance.layerCullDistances = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Layer Cull Spherical" )]
	class CameralayerCullSphericalGet40 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.layerCullSpherical;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Layer Cull Spherical" )]
	class CameralayerCullSphericalSet40 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.layerCullSpherical = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Depth Texture Mode" )]
	class CameradepthTextureModeGet41 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public UnityEngine.DepthTextureMode Result;

		public override IEnumerator Execute() {
			Result = Instance.depthTextureMode;
			yield break;
		}

	}

	[Automation( "Camera/Set Depth Texture Mode" )]
	class CameradepthTextureModeSet41 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.DepthTextureMode Value;

		public override IEnumerator Execute() {
			Instance.depthTextureMode = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Clear Stencil After Lighting Pass" )]
	class CameraclearStencilAfterLightingPassGet42 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.clearStencilAfterLightingPass;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Set Clear Stencil After Lighting Pass" )]
	class CameraclearStencilAfterLightingPassSet42 : Automation {

		public UnityEngine.Camera Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.clearStencilAfterLightingPass = Value;
			yield break;
		}

	}

	[Automation( "Camera/Get Command Buffer Count" )]
	class CameracommandBufferCountGet43 : Automation {

		public UnityEngine.Camera Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.commandBufferCount;
			yield break;
		}

	}

	[Automation( "Camera/Set Target Buffers" )]
	class CameraSetTargetBuffers0 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.RenderBuffer colorBuffer;
		public UnityEngine.RenderBuffer depthBuffer;

		public override IEnumerator Execute() {
			Instance.SetTargetBuffers(colorBuffer,depthBuffer);
			yield break;
		}

	}

	[Automation( "Camera/Reset World To Camera Matrix" )]
	class CameraResetWorldToCameraMatrix1 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetWorldToCameraMatrix();
			yield break;
		}

	}

	[Automation( "Camera/Reset Projection Matrix" )]
	class CameraResetProjectionMatrix2 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetProjectionMatrix();
			yield break;
		}

	}

	[Automation( "Camera/Reset Aspect" )]
	class CameraResetAspect3 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetAspect();
			yield break;
		}

	}

	[Automation( "Camera/Reset Field Of View" )]
	class CameraResetFieldOfView4 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetFieldOfView();
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo View Matrices" )]
	class CameraSetStereoViewMatrices5 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 leftMatrix;
		public UnityEngine.Matrix4x4 rightMatrix;

		public override IEnumerator Execute() {
			Instance.SetStereoViewMatrices(leftMatrix,rightMatrix);
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo View Matrix" )]
	class CameraGetStereoViewMatrix6 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera.StereoscopicEye eye;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetStereoViewMatrix(eye);
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo View Matrix" )]
	class CameraSetStereoViewMatrix7 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera.StereoscopicEye eye;
		public UnityEngine.Matrix4x4 matrix;

		public override IEnumerator Execute() {
			Instance.SetStereoViewMatrix(eye,matrix);
			yield break;
		}

	}

	[Automation( "Camera/Reset Stereo View Matrices" )]
	class CameraResetStereoViewMatrices8 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetStereoViewMatrices();
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Projection Matrices" )]
	class CameraSetStereoProjectionMatrices9 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Matrix4x4 leftMatrix;
		public UnityEngine.Matrix4x4 rightMatrix;

		public override IEnumerator Execute() {
			Instance.SetStereoProjectionMatrices(leftMatrix,rightMatrix);
			yield break;
		}

	}

	[Automation( "Camera/Get Stereo Projection Matrix" )]
	class CameraGetStereoProjectionMatrix10 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera.StereoscopicEye eye;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetStereoProjectionMatrix(eye);
			yield break;
		}

	}

	[Automation( "Camera/Set Stereo Projection Matrix" )]
	class CameraSetStereoProjectionMatrix11 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera.StereoscopicEye eye;
		public UnityEngine.Matrix4x4 matrix;

		public override IEnumerator Execute() {
			Instance.SetStereoProjectionMatrix(eye,matrix);
			yield break;
		}

	}

	[Automation( "Camera/Reset Stereo Projection Matrices" )]
	class CameraResetStereoProjectionMatrices12 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetStereoProjectionMatrices();
			yield break;
		}

	}

	[Automation( "Camera/World To Screen Point" )]
	class CameraWorldToScreenPoint13 : Automation {

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
	class CameraWorldToViewportPoint14 : Automation {

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
	class CameraViewportToWorldPoint15 : Automation {

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
	class CameraScreenToWorldPoint16 : Automation {

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
	class CameraScreenToViewportPoint17 : Automation {

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
	class CameraViewportToScreenPoint18 : Automation {

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
	class CameraViewportPointToRay19 : Automation {

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
	class CameraScreenPointToRay20 : Automation {

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
	class CameraRender22 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.Render();
			yield break;
		}

	}

	[Automation( "Camera/Render With Shader" )]
	class CameraRenderWithShader23 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Shader shader;
		public System.String replacementTag;

		public override IEnumerator Execute() {
			Instance.RenderWithShader(shader,replacementTag);
			yield break;
		}

	}

	[Automation( "Camera/Set Replacement Shader" )]
	class CameraSetReplacementShader24 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Shader shader;
		public System.String replacementTag;

		public override IEnumerator Execute() {
			Instance.SetReplacementShader(shader,replacementTag);
			yield break;
		}

	}

	[Automation( "Camera/Reset Replacement Shader" )]
	class CameraResetReplacementShader25 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetReplacementShader();
			yield break;
		}

	}

	[Automation( "Camera/Reset Culling Matrix" )]
	class CameraResetCullingMatrix26 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.ResetCullingMatrix();
			yield break;
		}

	}

	[Automation( "Camera/Render Dont Restore" )]
	class CameraRenderDontRestore27 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.RenderDontRestore();
			yield break;
		}

	}

	[Automation( "Camera/Setup Current" )]
	class CameraSetupCurrent28 : Automation {

		public UnityEngine.Camera cur;

		public override IEnumerator Execute() {
			UnityEngine.Camera.SetupCurrent(cur);
			yield break;
		}

	}

	[Automation( "Camera/Render To Cubemap" )]
	class CameraRenderToCubemap29 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Cubemap cubemap;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.RenderToCubemap(cubemap);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Render To Cubemap (RenderTexture)" )]
	class CameraRenderToCubemap30 : ConditionalAutomation {

		public UnityEngine.Camera Instance;
		public UnityEngine.RenderTexture cubemap;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.RenderToCubemap(cubemap);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Camera/Copy From" )]
	class CameraCopyFrom31 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Camera other;

		public override IEnumerator Execute() {
			Instance.CopyFrom(other);
			yield break;
		}

	}

	[Automation( "Camera/Add Command Buffer" )]
	class CameraAddCommandBuffer32 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rendering.CameraEvent evt;
		public UnityEngine.Rendering.CommandBuffer buffer;

		public override IEnumerator Execute() {
			Instance.AddCommandBuffer(evt,buffer);
			yield break;
		}

	}

	[Automation( "Camera/Remove Command Buffer" )]
	class CameraRemoveCommandBuffer33 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rendering.CameraEvent evt;
		public UnityEngine.Rendering.CommandBuffer buffer;

		public override IEnumerator Execute() {
			Instance.RemoveCommandBuffer(evt,buffer);
			yield break;
		}

	}

	[Automation( "Camera/Remove All Command Buffers" )]
	class CameraRemoveAllCommandBuffers34 : Automation {

		public UnityEngine.Camera Instance;

		public override IEnumerator Execute() {
			Instance.RemoveAllCommandBuffers();
			yield break;
		}

	}

	[Automation( "Camera/Get Command Buffers" )]
	class CameraGetCommandBuffers35 : Automation {

		public UnityEngine.Camera Instance;
		public UnityEngine.Rendering.CameraEvent evt;
		[ReadOnly]
		public UnityEngine.Rendering.CommandBuffer[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCommandBuffers(evt);
			yield break;
		}

	}

	[Automation( "Camera/Calculate Oblique Matrix" )]
	class CameraCalculateObliqueMatrix36 : Automation {

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
