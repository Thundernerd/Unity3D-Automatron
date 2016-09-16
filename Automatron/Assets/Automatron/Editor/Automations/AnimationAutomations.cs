using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Animation/Get Clip" )]
	class AnimationclipGet0 : Automation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationClip Result;

		public override IEnumerator Execute() {
			Result = Instance.clip;
			yield break;
		}

	}

	[Automation( "Animation/Set Clip" )]
	class AnimationclipSet0 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.AnimationClip Value;

		public override IEnumerator Execute() {
			Instance.clip = Value;
			yield break;
		}

	}

	[Automation( "Animation/Get Play Automatically" )]
	class AnimationplayAutomaticallyGet1 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.playAutomatically;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Set Play Automatically" )]
	class AnimationplayAutomaticallySet1 : Automation {

		public UnityEngine.Animation Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.playAutomatically = Value;
			yield break;
		}

	}

	[Automation( "Animation/Get Wrap Mode" )]
	class AnimationwrapModeGet2 : Automation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.WrapMode Result;

		public override IEnumerator Execute() {
			Result = Instance.wrapMode;
			yield break;
		}

	}

	[Automation( "Animation/Set Wrap Mode" )]
	class AnimationwrapModeSet2 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.WrapMode Value;

		public override IEnumerator Execute() {
			Instance.wrapMode = Value;
			yield break;
		}

	}

	[Automation( "Animation/Get Is Playing" )]
	class AnimationisPlayingGet3 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Get Animate Physics" )]
	class AnimationanimatePhysicsGet5 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.animatePhysics;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Set Animate Physics" )]
	class AnimationanimatePhysicsSet5 : Automation {

		public UnityEngine.Animation Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.animatePhysics = Value;
			yield break;
		}

	}

	[Automation( "Animation/Get Culling Type" )]
	class AnimationcullingTypeGet6 : Automation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationCullingType Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingType;
			yield break;
		}

	}

	[Automation( "Animation/Set Culling Type" )]
	class AnimationcullingTypeSet6 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.AnimationCullingType Value;

		public override IEnumerator Execute() {
			Instance.cullingType = Value;
			yield break;
		}

	}

	[Automation( "Animation/Get Local Bounds" )]
	class AnimationlocalBoundsGet7 : Automation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.localBounds;
			yield break;
		}

	}

	[Automation( "Animation/Set Local Bounds" )]
	class AnimationlocalBoundsSet7 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.Bounds Value;

		public override IEnumerator Execute() {
			Instance.localBounds = Value;
			yield break;
		}

	}

	[Automation( "Animation/Stop" )]
	class AnimationStop0 : Automation {

		public UnityEngine.Animation Instance;

		public override IEnumerator Execute() {
			Instance.Stop();
			yield break;
		}

	}

	[Automation( "Animation/Stop By Name" )]
	class AnimationStop1 : Automation {

		public UnityEngine.Animation Instance;
		public System.String name;

		public override IEnumerator Execute() {
			Instance.Stop(name);
			yield break;
		}

	}

	[Automation( "Animation/Rewind By Name" )]
	class AnimationRewind2 : Automation {

		public UnityEngine.Animation Instance;
		public System.String name;

		public override IEnumerator Execute() {
			Instance.Rewind(name);
			yield break;
		}

	}

	[Automation( "Animation/Rewind" )]
	class AnimationRewind3 : Automation {

		public UnityEngine.Animation Instance;

		public override IEnumerator Execute() {
			Instance.Rewind();
			yield break;
		}

	}

	[Automation( "Animation/Sample" )]
	class AnimationSample4 : Automation {

		public UnityEngine.Animation Instance;

		public override IEnumerator Execute() {
			Instance.Sample();
			yield break;
		}

	}

	[Automation( "Animation/Is Playing" )]
	class AnimationIsPlaying5 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsPlaying(name);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Play" )]
	class AnimationPlay6 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		public UnityEngine.PlayMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Play(mode);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Play By Name" )]
	class AnimationPlay7 : ConditionalAutomation {

		public UnityEngine.Animation Instance;
		public System.String animation;
		public UnityEngine.PlayMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Play(animation,mode);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Animation/Cross Fade" )]
	class AnimationCrossFade8 : Automation {

		public UnityEngine.Animation Instance;
		public System.String animation;
		public System.Single fadeLength;
		public UnityEngine.PlayMode mode;

		public override IEnumerator Execute() {
			Instance.CrossFade(animation,fadeLength,mode);
			yield break;
		}

	}

	[Automation( "Animation/Blend" )]
	class AnimationBlend9 : Automation {

		public UnityEngine.Animation Instance;
		public System.String animation;
		public System.Single targetWeight;
		public System.Single fadeLength;

		public override IEnumerator Execute() {
			Instance.Blend(animation,targetWeight,fadeLength);
			yield break;
		}

	}

	[Automation( "Animation/Cross Fade Queued" )]
	class AnimationCrossFadeQueued10 : Automation {

		public UnityEngine.Animation Instance;
		public System.String animation;
		public System.Single fadeLength;
		public UnityEngine.QueueMode queue;
		public UnityEngine.PlayMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationState Result;

		public override IEnumerator Execute() {
			Result = Instance.CrossFadeQueued(animation,fadeLength,queue,mode);
			yield break;
		}

	}

	[Automation( "Animation/Play Queued" )]
	class AnimationPlayQueued11 : Automation {

		public UnityEngine.Animation Instance;
		public System.String animation;
		public UnityEngine.QueueMode queue;
		public UnityEngine.PlayMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationState Result;

		public override IEnumerator Execute() {
			Result = Instance.PlayQueued(animation,queue,mode);
			yield break;
		}

	}

	[Automation( "Animation/Add Clip" )]
	class AnimationAddClip12 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.AnimationClip clip;
		public System.String newName;

		public override IEnumerator Execute() {
			Instance.AddClip(clip,newName);
			yield break;
		}

	}

	[Automation( "Animation/Remove Clip" )]
	class AnimationRemoveClip13 : Automation {

		public UnityEngine.Animation Instance;
		public UnityEngine.AnimationClip clip;

		public override IEnumerator Execute() {
			Instance.RemoveClip(clip);
			yield break;
		}

	}

	[Automation( "Animation/Remove Clip By Name" )]
	class AnimationRemoveClip14 : Automation {

		public UnityEngine.Animation Instance;
		public System.String clipName;

		public override IEnumerator Execute() {
			Instance.RemoveClip(clipName);
			yield break;
		}

	}

	[Automation( "Animation/Get Clip Count" )]
	class AnimationGetClipCount15 : Automation {

		public UnityEngine.Animation Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetClipCount();
			yield break;
		}

	}

	[Automation( "Animation/Sync Layer" )]
	class AnimationSyncLayer16 : Automation {

		public UnityEngine.Animation Instance;
		public System.Int32 layer;

		public override IEnumerator Execute() {
			Instance.SyncLayer(layer);
			yield break;
		}

	}

	[Automation( "Animation/Get Clip By Name" )]
	class AnimationGetClip17 : Automation {

		public UnityEngine.Animation Instance;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationClip Result;

		public override IEnumerator Execute() {
			Result = Instance.GetClip(name);
			yield break;
		}

	}


#pragma warning restore 0649
}
