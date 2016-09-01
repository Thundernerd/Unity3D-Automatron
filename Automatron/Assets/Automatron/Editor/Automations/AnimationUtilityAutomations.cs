using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Animation Utility/Get Animation Clips" )]
	class AnimationUtilityGetAnimationClips0 : Automation {

		public UnityEngine.GameObject gameObject;
		[ReadOnly]
		public UnityEngine.AnimationClip[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationClips(gameObject);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Animation Clips" )]
	class AnimationUtilitySetAnimationClips1 : Automation {

		public UnityEngine.Animation animation;
		public UnityEngine.AnimationClip[] clips;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationClips(animation,clips);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Animatable Bindings" )]
	class AnimationUtilityGetAnimatableBindings2 : Automation {

		public UnityEngine.GameObject targetObject;
		public UnityEngine.GameObject root;
		[ReadOnly]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimatableBindings(targetObject,root);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Float Value" )]
	class AnimationUtilityGetFloatValue3 : ConditionalAutomation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		public System.Single data;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AnimationUtility.GetFloatValue(root,binding,out data);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Animation Utility/Get Editor Curve Value Type" )]
	class AnimationUtilityGetEditorCurveValueType4 : Automation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetEditorCurveValueType(root,binding);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Object Reference Value" )]
	class AnimationUtilityGetObjectReferenceValue5 : ConditionalAutomation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEngine.Object targetObject;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceValue(root,binding,out targetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Animation Utility/Get Animated Object" )]
	class AnimationUtilityGetAnimatedObject6 : Automation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimatedObject(root,binding);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Property Modification To Editor Curve Binding" )]
	class AnimationUtilityPropertyModificationToEditorCurveBinding7 : Automation {

		public UnityEditor.PropertyModification modification;
		public UnityEngine.GameObject gameObject;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.PropertyModificationToEditorCurveBinding(modification,gameObject,out binding);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Curve Bindings" )]
	class AnimationUtilityGetCurveBindings8 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetCurveBindings(clip);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Object Reference Curve Bindings" )]
	class AnimationUtilityGetObjectReferenceCurveBindings9 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceCurveBindings(clip);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Object Reference Curve" )]
	class AnimationUtilityGetObjectReferenceCurve10 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		public UnityEditor.ObjectReferenceKeyframe[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceCurve(clip,binding);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Editor Curve" )]
	class AnimationUtilityGetEditorCurve11 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		public UnityEngine.AnimationCurve Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetEditorCurve(clip,binding);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Editor Curve" )]
	class AnimationUtilitySetEditorCurve12 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEngine.AnimationCurve curve;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetEditorCurve(clip,binding,curve);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Object Reference Curve" )]
	class AnimationUtilitySetObjectReferenceCurve13 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEditor.ObjectReferenceKeyframe[] keyframes;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetObjectReferenceCurve(clip,binding,keyframes);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Animation Events" )]
	class AnimationUtilityGetAnimationEvents14 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		public UnityEngine.AnimationEvent[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationEvents(clip);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Animation Events" )]
	class AnimationUtilitySetAnimationEvents15 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEngine.AnimationEvent[] events;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationEvents(clip,events);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Calculate Transform Path" )]
	class AnimationUtilityCalculateTransformPath16 : Automation {

		public UnityEngine.Transform targetTransform;
		public UnityEngine.Transform root;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.CalculateTransformPath(targetTransform,root);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Get Animation Clip Settings" )]
	class AnimationUtilityGetAnimationClipSettings17 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		public UnityEditor.AnimationClipSettings Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationClipSettings(clip);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Animation Clip Settings" )]
	class AnimationUtilitySetAnimationClipSettings18 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.AnimationClipSettings srcClipInfo;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationClipSettings(clip,srcClipInfo);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Set Additive Reference Pose" )]
	class AnimationUtilitySetAdditiveReferencePose19 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEngine.AnimationClip referenceClip;
		public System.Single time;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAdditiveReferencePose(clip,referenceClip,time);
			yield break;
		}

	}

	[Automation( "Utilities/Animation Utility/Is Valid Polynomial Curve" )]
	class AnimationUtilityIsValidPolynomialCurve20 : ConditionalAutomation {

		public UnityEngine.AnimationCurve curve;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AnimationUtility.IsValidPolynomialCurve(curve);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Animation Utility/Constrain To Polynomial Curve" )]
	class AnimationUtilityConstrainToPolynomialCurve21 : Automation {

		public UnityEngine.AnimationCurve curve;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.ConstrainToPolynomialCurve(curve);
			yield break;
		}

	}


#pragma warning restore 0649
}
