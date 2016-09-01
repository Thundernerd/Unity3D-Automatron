using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Animator/Get Is Optimizable" )]
	class AnimatorisOptimizableGet0 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isOptimizable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Is Human" )]
	class AnimatorisHumanGet1 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isHuman;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Has Root Motion" )]
	class AnimatorhasRootMotionGet2 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasRootMotion;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Human Scale" )]
	class AnimatorhumanScaleGet3 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.humanScale;
			yield break;
		}

	}

	[Automation( "Animator/Get Is Initialized" )]
	class AnimatorisInitializedGet4 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isInitialized;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Delta Position" )]
	class AnimatordeltaPositionGet5 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.deltaPosition;
			yield break;
		}

	}

	[Automation( "Animator/Get Delta Rotation" )]
	class AnimatordeltaRotationGet6 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.deltaRotation;
			yield break;
		}

	}

	[Automation( "Animator/Get Velocity" )]
	class AnimatorvelocityGet7 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Animator/Get Angular Velocity" )]
	class AnimatorangularVelocityGet8 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.angularVelocity;
			yield break;
		}

	}

	[Automation( "Animator/Get Root Position" )]
	class AnimatorrootPositionGet9 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.rootPosition;
			yield break;
		}

	}

	[Automation( "Animator/Set Root Position" )]
	class AnimatorrootPositionSet9 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.rootPosition = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Root Rotation" )]
	class AnimatorrootRotationGet10 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.rootRotation;
			yield break;
		}

	}

	[Automation( "Animator/Set Root Rotation" )]
	class AnimatorrootRotationSet10 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.rootRotation = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Apply Root Motion" )]
	class AnimatorapplyRootMotionGet11 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.applyRootMotion;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Apply Root Motion" )]
	class AnimatorapplyRootMotionSet11 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.applyRootMotion = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Linear Velocity Blending" )]
	class AnimatorlinearVelocityBlendingGet12 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.linearVelocityBlending;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Linear Velocity Blending" )]
	class AnimatorlinearVelocityBlendingSet12 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.linearVelocityBlending = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Update Mode" )]
	class AnimatorupdateModeGet13 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.AnimatorUpdateMode Result;

		public override IEnumerator Execute() {
			Result = Instance.updateMode;
			yield break;
		}

	}

	[Automation( "Animator/Set Update Mode" )]
	class AnimatorupdateModeSet13 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.AnimatorUpdateMode Value;

		public override IEnumerator Execute() {
			Instance.updateMode = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Has Transform Hierarchy" )]
	class AnimatorhasTransformHierarchyGet14 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasTransformHierarchy;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Gravity Weight" )]
	class AnimatorgravityWeightGet15 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.gravityWeight;
			yield break;
		}

	}

	[Automation( "Animator/Get Body Position" )]
	class AnimatorbodyPositionGet16 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.bodyPosition;
			yield break;
		}

	}

	[Automation( "Animator/Set Body Position" )]
	class AnimatorbodyPositionSet16 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.bodyPosition = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Body Rotation" )]
	class AnimatorbodyRotationGet17 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.bodyRotation;
			yield break;
		}

	}

	[Automation( "Animator/Set Body Rotation" )]
	class AnimatorbodyRotationSet17 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.bodyRotation = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Stabilize Feet" )]
	class AnimatorstabilizeFeetGet18 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.stabilizeFeet;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Stabilize Feet" )]
	class AnimatorstabilizeFeetSet18 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.stabilizeFeet = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Layer Count" )]
	class AnimatorlayerCountGet19 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.layerCount;
			yield break;
		}

	}

	[Automation( "Animator/Get Parameters" )]
	class AnimatorparametersGet20 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.AnimatorControllerParameter[] Result;

		public override IEnumerator Execute() {
			Result = Instance.parameters;
			yield break;
		}

	}

	[Automation( "Animator/Get Parameter Count" )]
	class AnimatorparameterCountGet21 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.parameterCount;
			yield break;
		}

	}

	[Automation( "Animator/Get Feet Pivot Active" )]
	class AnimatorfeetPivotActiveGet22 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.feetPivotActive;
			yield break;
		}

	}

	[Automation( "Animator/Set Feet Pivot Active" )]
	class AnimatorfeetPivotActiveSet22 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.feetPivotActive = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Pivot Weight" )]
	class AnimatorpivotWeightGet23 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.pivotWeight;
			yield break;
		}

	}

	[Automation( "Animator/Get Pivot Position" )]
	class AnimatorpivotPositionGet24 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.pivotPosition;
			yield break;
		}

	}

	[Automation( "Animator/Get Is Matching Target" )]
	class AnimatorisMatchingTargetGet25 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isMatchingTarget;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Speed" )]
	class AnimatorspeedGet26 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.speed;
			yield break;
		}

	}

	[Automation( "Animator/Set Speed" )]
	class AnimatorspeedSet26 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.speed = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Target Position" )]
	class AnimatortargetPositionGet27 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetPosition;
			yield break;
		}

	}

	[Automation( "Animator/Get Target Rotation" )]
	class AnimatortargetRotationGet28 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.targetRotation;
			yield break;
		}

	}

	[Automation( "Animator/Get Culling Mode" )]
	class AnimatorcullingModeGet29 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.AnimatorCullingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMode;
			yield break;
		}

	}

	[Automation( "Animator/Set Culling Mode" )]
	class AnimatorcullingModeSet29 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.AnimatorCullingMode Value;

		public override IEnumerator Execute() {
			Instance.cullingMode = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Playback Time" )]
	class AnimatorplaybackTimeGet30 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.playbackTime;
			yield break;
		}

	}

	[Automation( "Animator/Set Playback Time" )]
	class AnimatorplaybackTimeSet30 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.playbackTime = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Recorder Start Time" )]
	class AnimatorrecorderStartTimeGet31 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.recorderStartTime;
			yield break;
		}

	}

	[Automation( "Animator/Set Recorder Start Time" )]
	class AnimatorrecorderStartTimeSet31 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.recorderStartTime = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Recorder Stop Time" )]
	class AnimatorrecorderStopTimeGet32 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.recorderStopTime;
			yield break;
		}

	}

	[Automation( "Animator/Set Recorder Stop Time" )]
	class AnimatorrecorderStopTimeSet32 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.recorderStopTime = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Recorder Mode" )]
	class AnimatorrecorderModeGet33 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.AnimatorRecorderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.recorderMode;
			yield break;
		}

	}

	[Automation( "Animator/Get Runtime Animator Controller" )]
	class AnimatorruntimeAnimatorControllerGet34 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.RuntimeAnimatorController Result;

		public override IEnumerator Execute() {
			Result = Instance.runtimeAnimatorController;
			yield break;
		}

	}

	[Automation( "Animator/Set Runtime Animator Controller" )]
	class AnimatorruntimeAnimatorControllerSet34 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.RuntimeAnimatorController Value;

		public override IEnumerator Execute() {
			Instance.runtimeAnimatorController = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Avatar" )]
	class AnimatoravatarGet35 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public UnityEngine.Avatar Result;

		public override IEnumerator Execute() {
			Result = Instance.avatar;
			yield break;
		}

	}

	[Automation( "Animator/Set Avatar" )]
	class AnimatoravatarSet35 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Avatar Value;

		public override IEnumerator Execute() {
			Instance.avatar = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Layers Affect Mass Center" )]
	class AnimatorlayersAffectMassCenterGet36 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.layersAffectMassCenter;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Layers Affect Mass Center" )]
	class AnimatorlayersAffectMassCenterSet36 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.layersAffectMassCenter = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Left Feet Bottom Height" )]
	class AnimatorleftFeetBottomHeightGet37 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.leftFeetBottomHeight;
			yield break;
		}

	}

	[Automation( "Animator/Get Right Feet Bottom Height" )]
	class AnimatorrightFeetBottomHeightGet38 : Automation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rightFeetBottomHeight;
			yield break;
		}

	}

	[Automation( "Animator/Get Log Warnings" )]
	class AnimatorlogWarningsGet39 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.logWarnings;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Log Warnings" )]
	class AnimatorlogWarningsSet39 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.logWarnings = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Fire Events" )]
	class AnimatorfireEventsGet40 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.fireEvents;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Fire Events" )]
	class AnimatorfireEventsSet40 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.fireEvents = Value;
			yield break;
		}

	}

	[Automation( "Animator/Get Float" )]
	class AnimatorGetFloat0 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetFloat(name);
			yield break;
		}

	}

	[Automation( "Animator/Set Float" )]
	class AnimatorSetFloat1 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;
		public System.Single value;

		public override IEnumerator Execute() {
			Instance.SetFloat(name,value);
			yield break;
		}

	}

	[Automation( "Animator/Get Bool" )]
	class AnimatorGetBool2 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		public System.String name;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.GetBool(name);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Set Bool" )]
	class AnimatorSetBool3 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;
		public System.Boolean value;

		public override IEnumerator Execute() {
			Instance.SetBool(name,value);
			yield break;
		}

	}

	[Automation( "Animator/Get Integer" )]
	class AnimatorGetInteger4 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetInteger(name);
			yield break;
		}

	}

	[Automation( "Animator/Set Integer" )]
	class AnimatorSetInteger5 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;
		public System.Int32 value;

		public override IEnumerator Execute() {
			Instance.SetInteger(name,value);
			yield break;
		}

	}

	[Automation( "Animator/Set Trigger" )]
	class AnimatorSetTrigger6 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;

		public override IEnumerator Execute() {
			Instance.SetTrigger(name);
			yield break;
		}

	}

	[Automation( "Animator/Reset Trigger" )]
	class AnimatorResetTrigger7 : Automation {

		public UnityEngine.Animator Instance;
		public System.String name;

		public override IEnumerator Execute() {
			Instance.ResetTrigger(name);
			yield break;
		}

	}

	[Automation( "Animator/Is Parameter Controlled By Curve" )]
	class AnimatorIsParameterControlledByCurve8 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		public System.String name;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsParameterControlledByCurve(name);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Layer Name" )]
	class AnimatorGetLayerName9 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLayerName(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Get Layer Index" )]
	class AnimatorGetLayerIndex10 : Automation {

		public UnityEngine.Animator Instance;
		public System.String layerName;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLayerIndex(layerName);
			yield break;
		}

	}

	[Automation( "Animator/Get Layer Weight" )]
	class AnimatorGetLayerWeight11 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLayerWeight(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Set Layer Weight" )]
	class AnimatorSetLayerWeight12 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		public System.Single weight;

		public override IEnumerator Execute() {
			Instance.SetLayerWeight(layerIndex,weight);
			yield break;
		}

	}

	[Automation( "Animator/Get Current Animator State Info" )]
	class AnimatorGetCurrentAnimatorStateInfo13 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public UnityEngine.AnimatorStateInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCurrentAnimatorStateInfo(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Get Next Animator State Info" )]
	class AnimatorGetNextAnimatorStateInfo14 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public UnityEngine.AnimatorStateInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.GetNextAnimatorStateInfo(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Get Animator Transition Info" )]
	class AnimatorGetAnimatorTransitionInfo15 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public UnityEngine.AnimatorTransitionInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAnimatorTransitionInfo(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Get Current Animator Clip Info" )]
	class AnimatorGetCurrentAnimatorClipInfo16 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public UnityEngine.AnimatorClipInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCurrentAnimatorClipInfo(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Get Next Animator Clip Info" )]
	class AnimatorGetNextAnimatorClipInfo17 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public UnityEngine.AnimatorClipInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetNextAnimatorClipInfo(layerIndex);
			yield break;
		}

	}

	[Automation( "Animator/Is In Transition" )]
	class AnimatorIsInTransition18 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsInTransition(layerIndex);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/Get Parameter" )]
	class AnimatorGetParameter19 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 index;
		[ReadOnly]
		public UnityEngine.AnimatorControllerParameter Result;

		public override IEnumerator Execute() {
			Result = Instance.GetParameter(index);
			yield break;
		}

	}

	[Automation( "Animator/Match Target" )]
	class AnimatorMatchTarget20 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.Vector3 matchPosition;
		public UnityEngine.Quaternion matchRotation;
		public UnityEngine.AvatarTarget targetBodyPart;
		public UnityEngine.MatchTargetWeightMask weightMask;
		public System.Single startNormalizedTime;
		public System.Single targetNormalizedTime;

		public override IEnumerator Execute() {
			Instance.MatchTarget(matchPosition,matchRotation,targetBodyPart,weightMask,startNormalizedTime,targetNormalizedTime);
			yield break;
		}

	}

	[Automation( "Animator/Interrupt Match Target" )]
	class AnimatorInterruptMatchTarget22 : Automation {

		public UnityEngine.Animator Instance;
		public System.Boolean completeMatch;

		public override IEnumerator Execute() {
			Instance.InterruptMatchTarget(completeMatch);
			yield break;
		}

	}

	[Automation( "Animator/Cross Fade In Fixed Time" )]
	class AnimatorCrossFadeInFixedTime23 : Automation {

		public UnityEngine.Animator Instance;
		public System.String stateName;
		public System.Single transitionDuration;
		public System.Int32 layer;
		public System.Single fixedTime;

		public override IEnumerator Execute() {
			Instance.CrossFadeInFixedTime(stateName,transitionDuration,layer,fixedTime);
			yield break;
		}

	}

	[Automation( "Animator/Cross Fade" )]
	class AnimatorCrossFade24 : Automation {

		public UnityEngine.Animator Instance;
		public System.String stateName;
		public System.Single transitionDuration;
		public System.Int32 layer;
		public System.Single normalizedTime;

		public override IEnumerator Execute() {
			Instance.CrossFade(stateName,transitionDuration,layer,normalizedTime);
			yield break;
		}

	}

	[Automation( "Animator/Play In Fixed Time" )]
	class AnimatorPlayInFixedTime25 : Automation {

		public UnityEngine.Animator Instance;
		public System.String stateName;
		public System.Int32 layer;
		public System.Single fixedTime;

		public override IEnumerator Execute() {
			Instance.PlayInFixedTime(stateName,layer,fixedTime);
			yield break;
		}

	}

	[Automation( "Animator/Play" )]
	class AnimatorPlay26 : Automation {

		public UnityEngine.Animator Instance;
		public System.String stateName;
		public System.Int32 layer;
		public System.Single normalizedTime;

		public override IEnumerator Execute() {
			Instance.Play(stateName,layer,normalizedTime);
			yield break;
		}

	}

	[Automation( "Animator/Set Target" )]
	class AnimatorSetTarget27 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.AvatarTarget targetIndex;
		public System.Single targetNormalizedTime;

		public override IEnumerator Execute() {
			Instance.SetTarget(targetIndex,targetNormalizedTime);
			yield break;
		}

	}

	[Automation( "Animator/Get Bone Transform" )]
	class AnimatorGetBoneTransform28 : Automation {

		public UnityEngine.Animator Instance;
		public UnityEngine.HumanBodyBones humanBoneId;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.GetBoneTransform(humanBoneId);
			yield break;
		}

	}

	[Automation( "Animator/Start Playback" )]
	class AnimatorStartPlayback29 : Automation {

		public UnityEngine.Animator Instance;

		public override IEnumerator Execute() {
			Instance.StartPlayback();
			yield break;
		}

	}

	[Automation( "Animator/Stop Playback" )]
	class AnimatorStopPlayback30 : Automation {

		public UnityEngine.Animator Instance;

		public override IEnumerator Execute() {
			Instance.StopPlayback();
			yield break;
		}

	}

	[Automation( "Animator/Start Recording" )]
	class AnimatorStartRecording31 : Automation {

		public UnityEngine.Animator Instance;
		public System.Int32 frameCount;

		public override IEnumerator Execute() {
			Instance.StartRecording(frameCount);
			yield break;
		}

	}

	[Automation( "Animator/Stop Recording" )]
	class AnimatorStopRecording32 : Automation {

		public UnityEngine.Animator Instance;

		public override IEnumerator Execute() {
			Instance.StopRecording();
			yield break;
		}

	}

	[Automation( "Animator/Has State" )]
	class AnimatorHasState33 : ConditionalAutomation {

		public UnityEngine.Animator Instance;
		public System.Int32 layerIndex;
		public System.Int32 stateID;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.HasState(layerIndex,stateID);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animator/String To Hash" )]
	class AnimatorStringToHash34 : Automation {

		public System.String name;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Animator.StringToHash(name);
			yield break;
		}

	}

	[Automation( "Animator/Update" )]
	class AnimatorUpdate35 : Automation {

		public UnityEngine.Animator Instance;
		public System.Single deltaTime;

		public override IEnumerator Execute() {
			Instance.Update(deltaTime);
			yield break;
		}

	}

	[Automation( "Animator/Rebind" )]
	class AnimatorRebind36 : Automation {

		public UnityEngine.Animator Instance;

		public override IEnumerator Execute() {
			Instance.Rebind();
			yield break;
		}

	}

	[Automation( "Animator/Apply Builtin Root Motion" )]
	class AnimatorApplyBuiltinRootMotion37 : Automation {

		public UnityEngine.Animator Instance;

		public override IEnumerator Execute() {
			Instance.ApplyBuiltinRootMotion();
			yield break;
		}

	}


#pragma warning restore 0649
}
