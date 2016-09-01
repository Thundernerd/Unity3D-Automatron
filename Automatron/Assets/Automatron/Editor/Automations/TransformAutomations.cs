using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Transform/Get Position" )]
	class TransformpositionGet0 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.position;
			yield break;
		}

	}

	[Automation( "Transform/Set Position" )]
	class TransformpositionSet0 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.position = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Local Position" )]
	class TransformlocalPositionGet1 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localPosition;
			yield break;
		}

	}

	[Automation( "Transform/Set Local Position" )]
	class TransformlocalPositionSet1 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localPosition = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Euler Angles" )]
	class TransformeulerAnglesGet2 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.eulerAngles;
			yield break;
		}

	}

	[Automation( "Transform/Set Euler Angles" )]
	class TransformeulerAnglesSet2 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.eulerAngles = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Local Euler Angles" )]
	class TransformlocalEulerAnglesGet3 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localEulerAngles;
			yield break;
		}

	}

	[Automation( "Transform/Set Local Euler Angles" )]
	class TransformlocalEulerAnglesSet3 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localEulerAngles = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Right" )]
	class TransformrightGet4 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.right;
			yield break;
		}

	}

	[Automation( "Transform/Set Right" )]
	class TransformrightSet4 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.right = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Up" )]
	class TransformupGet5 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.up;
			yield break;
		}

	}

	[Automation( "Transform/Set Up" )]
	class TransformupSet5 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.up = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Forward" )]
	class TransformforwardGet6 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.forward;
			yield break;
		}

	}

	[Automation( "Transform/Set Forward" )]
	class TransformforwardSet6 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.forward = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Rotation" )]
	class TransformrotationGet7 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.rotation;
			yield break;
		}

	}

	[Automation( "Transform/Set Rotation" )]
	class TransformrotationSet7 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.rotation = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Local Rotation" )]
	class TransformlocalRotationGet8 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.localRotation;
			yield break;
		}

	}

	[Automation( "Transform/Set Local Rotation" )]
	class TransformlocalRotationSet8 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.localRotation = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Local Scale" )]
	class TransformlocalScaleGet9 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localScale;
			yield break;
		}

	}

	[Automation( "Transform/Set Local Scale" )]
	class TransformlocalScaleSet9 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localScale = Value;
			yield break;
		}

	}

	[Automation( "Transform/Get Parent" )]
	class TransformparentGet10 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.parent;
			yield break;
		}

	}

	[Automation( "Transform/Get World To Local Matrix" )]
	class TransformworldToLocalMatrixGet11 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldToLocalMatrix;
			yield break;
		}

	}

	[Automation( "Transform/Get Local To World Matrix" )]
	class TransformlocalToWorldMatrixGet12 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.localToWorldMatrix;
			yield break;
		}

	}

	[Automation( "Transform/Get Root" )]
	class TransformrootGet13 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.root;
			yield break;
		}

	}

	[Automation( "Transform/Get Child Count" )]
	class TransformchildCountGet14 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.childCount;
			yield break;
		}

	}

	[Automation( "Transform/Get Lossy Scale" )]
	class TransformlossyScaleGet15 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.lossyScale;
			yield break;
		}

	}

	[Automation( "Transform/Get Has Changed" )]
	class TransformhasChangedGet16 : ConditionalAutomation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasChanged;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Transform/Set Has Changed" )]
	class TransformhasChangedSet16 : Automation {

		public UnityEngine.Transform Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.hasChanged = Value;
			yield break;
		}

	}

	[Automation( "Transform/Set Parent" )]
	class TransformSetParent0 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Transform parent;
		public System.Boolean worldPositionStays;

		public override IEnumerator Execute() {
			Instance.SetParent(parent,worldPositionStays);
			yield break;
		}

	}

	[Automation( "Transform/Translate" )]
	class TransformTranslate1 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 translation;

		public override IEnumerator Execute() {
			Instance.Translate(translation);
			yield break;
		}

	}

	[Automation( "Transform/Rotate" )]
	class TransformRotate2 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 eulerAngles;

		public override IEnumerator Execute() {
			Instance.Rotate(eulerAngles);
			yield break;
		}

	}

	[Automation( "Transform/Rotate Around" )]
	class TransformRotateAround3 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 point;
		public UnityEngine.Vector3 axis;
		public System.Single angle;

		public override IEnumerator Execute() {
			Instance.RotateAround(point,axis,angle);
			yield break;
		}

	}

	[Automation( "Transform/Look At" )]
	class TransformLookAt4 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 worldPosition;
		public UnityEngine.Vector3 worldUp;

		public override IEnumerator Execute() {
			Instance.LookAt(worldPosition,worldUp);
			yield break;
		}

	}

	[Automation( "Transform/Transform Direction" )]
	class TransformTransformDirection5 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.TransformDirection(direction);
			yield break;
		}

	}

	[Automation( "Transform/Inverse Transform Direction" )]
	class TransformInverseTransformDirection6 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.InverseTransformDirection(direction);
			yield break;
		}

	}

	[Automation( "Transform/Transform Vector" )]
	class TransformTransformVector7 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 vector;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.TransformVector(vector);
			yield break;
		}

	}

	[Automation( "Transform/Inverse Transform Vector" )]
	class TransformInverseTransformVector8 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 vector;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.InverseTransformVector(vector);
			yield break;
		}

	}

	[Automation( "Transform/Transform Point" )]
	class TransformTransformPoint9 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.TransformPoint(position);
			yield break;
		}

	}

	[Automation( "Transform/Inverse Transform Point" )]
	class TransformInverseTransformPoint10 : Automation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.InverseTransformPoint(position);
			yield break;
		}

	}

	[Automation( "Transform/Detach Children" )]
	class TransformDetachChildren11 : Automation {

		public UnityEngine.Transform Instance;

		public override IEnumerator Execute() {
			Instance.DetachChildren();
			yield break;
		}

	}

	[Automation( "Transform/Set As First Sibling" )]
	class TransformSetAsFirstSibling12 : Automation {

		public UnityEngine.Transform Instance;

		public override IEnumerator Execute() {
			Instance.SetAsFirstSibling();
			yield break;
		}

	}

	[Automation( "Transform/Set As Last Sibling" )]
	class TransformSetAsLastSibling13 : Automation {

		public UnityEngine.Transform Instance;

		public override IEnumerator Execute() {
			Instance.SetAsLastSibling();
			yield break;
		}

	}

	[Automation( "Transform/Set Sibling Index" )]
	class TransformSetSiblingIndex14 : Automation {

		public UnityEngine.Transform Instance;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.SetSiblingIndex(index);
			yield break;
		}

	}

	[Automation( "Transform/Get Sibling Index" )]
	class TransformGetSiblingIndex15 : Automation {

		public UnityEngine.Transform Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetSiblingIndex();
			yield break;
		}

	}

	[Automation( "Transform/Find" )]
	class TransformFind16 : Automation {

		public UnityEngine.Transform Instance;
		public System.String name;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.Find(name);
			yield break;
		}

	}

	[Automation( "Transform/Is Child Of" )]
	class TransformIsChildOf17 : ConditionalAutomation {

		public UnityEngine.Transform Instance;
		public UnityEngine.Transform parent;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsChildOf(parent);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Transform/Find Child" )]
	class TransformFindChild18 : Automation {

		public UnityEngine.Transform Instance;
		public System.String name;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.FindChild(name);
			yield break;
		}

	}

	[Automation( "Transform/Get Child" )]
	class TransformGetChild19 : Automation {

		public UnityEngine.Transform Instance;
		public System.Int32 index;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.GetChild(index);
			yield break;
		}

	}


#pragma warning restore 0649
}
