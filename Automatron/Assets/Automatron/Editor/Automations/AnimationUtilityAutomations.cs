#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Animation Utility/Get Animation Clips" )]
	class AnimationUtilityGetAnimationClips0 : Automation {

		public UnityEngine.GameObject gameObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationClip[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationClips(gameObject);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Animation Clips" )]
	class AnimationUtilitySetAnimationClips1 : Automation {

		public UnityEngine.Animation animation;
		public UnityEngine.AnimationClip[] clips;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationClips(animation,clips);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Animatable Bindings" )]
	class AnimationUtilityGetAnimatableBindings2 : Automation {

		public UnityEngine.GameObject targetObject;
		public UnityEngine.GameObject root;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimatableBindings(targetObject,root);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Float Value" )]
	class AnimationUtilityGetFloatValue3 : ConditionalAutomation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		public System.Single data;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetFloatValue(root,binding,out data);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation Utility/Get Editor Curve Value Type" )]
	class AnimationUtilityGetEditorCurveValueType4 : Automation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetEditorCurveValueType(root,binding);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Object Reference Value" )]
	class AnimationUtilityGetObjectReferenceValue5 : ConditionalAutomation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEngine.Object targetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceValue(root,binding,out targetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation Utility/Get Animated Object" )]
	class AnimationUtilityGetAnimatedObject6 : Automation {

		public UnityEngine.GameObject root;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimatedObject(root,binding);
			yield break;
		}

	}

	[Automation( "Animation Utility/Property Modification To Editor Curve Binding" )]
	class AnimationUtilityPropertyModificationToEditorCurveBinding7 : Automation {

		public UnityEditor.PropertyModification modification;
		public UnityEngine.GameObject gameObject;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.PropertyModificationToEditorCurveBinding(modification,gameObject,out binding);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Curve Bindings" )]
	class AnimationUtilityGetCurveBindings8 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetCurveBindings(clip);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Object Reference Curve Bindings" )]
	class AnimationUtilityGetObjectReferenceCurveBindings9 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.EditorCurveBinding[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceCurveBindings(clip);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Object Reference Curve" )]
	class AnimationUtilityGetObjectReferenceCurve10 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ObjectReferenceKeyframe[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetObjectReferenceCurve(clip,binding);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Editor Curve" )]
	class AnimationUtilityGetEditorCurve11 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationCurve Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetEditorCurve(clip,binding);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Editor Curve" )]
	class AnimationUtilitySetEditorCurve12 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEngine.AnimationCurve curve;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetEditorCurve(clip,binding,curve);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Object Reference Curve" )]
	class AnimationUtilitySetObjectReferenceCurve13 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.EditorCurveBinding binding;
		public UnityEditor.ObjectReferenceKeyframe[] keyframes;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetObjectReferenceCurve(clip,binding,keyframes);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Key Broken" )]
	class AnimationUtilitySetKeyBroken14 : Automation {

		public UnityEngine.AnimationCurve curve;
		public System.Int32 index;
		public System.Boolean broken;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetKeyBroken(curve,index,broken);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Key Left Tangent Mode" )]
	class AnimationUtilitySetKeyLeftTangentMode15 : Automation {

		public UnityEngine.AnimationCurve curve;
		public System.Int32 index;
		public UnityEditor.AnimationUtility.TangentMode tangentMode;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetKeyLeftTangentMode(curve,index,tangentMode);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Key Right Tangent Mode" )]
	class AnimationUtilitySetKeyRightTangentMode16 : Automation {

		public UnityEngine.AnimationCurve curve;
		public System.Int32 index;
		public UnityEditor.AnimationUtility.TangentMode tangentMode;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetKeyRightTangentMode(curve,index,tangentMode);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Animation Events" )]
	class AnimationUtilityGetAnimationEvents17 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationEvent[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationEvents(clip);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Animation Events" )]
	class AnimationUtilitySetAnimationEvents18 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEngine.AnimationEvent[] events;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationEvents(clip,events);
			yield break;
		}

	}

	[Automation( "Animation Utility/Calculate Transform Path" )]
	class AnimationUtilityCalculateTransformPath19 : Automation {

		public UnityEngine.Transform targetTransform;
		public UnityEngine.Transform root;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.CalculateTransformPath(targetTransform,root);
			yield break;
		}

	}

	[Automation( "Animation Utility/Get Animation Clip Settings" )]
	class AnimationUtilityGetAnimationClipSettings20 : Automation {

		public UnityEngine.AnimationClip clip;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.AnimationClipSettings Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.GetAnimationClipSettings(clip);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Animation Clip Settings" )]
	class AnimationUtilitySetAnimationClipSettings21 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEditor.AnimationClipSettings srcClipInfo;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAnimationClipSettings(clip,srcClipInfo);
			yield break;
		}

	}

	[Automation( "Animation Utility/Set Additive Reference Pose" )]
	class AnimationUtilitySetAdditiveReferencePose22 : Automation {

		public UnityEngine.AnimationClip clip;
		public UnityEngine.AnimationClip referenceClip;
		public System.Single time;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.SetAdditiveReferencePose(clip,referenceClip,time);
			yield break;
		}

	}

	[Automation( "Animation Utility/Is Valid Polynomial Curve" )]
	class AnimationUtilityIsValidPolynomialCurve23 : ConditionalAutomation {

		public UnityEngine.AnimationCurve curve;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AnimationUtility.IsValidPolynomialCurve(curve);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation Utility/Constrain To Polynomial Curve" )]
	class AnimationUtilityConstrainToPolynomialCurve24 : Automation {

		public UnityEngine.AnimationCurve curve;

		public override IEnumerator Execute() {
			UnityEditor.AnimationUtility.ConstrainToPolynomialCurve(curve);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif