using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Serialized Object/Get Target Object" )]
	class SerializedObjecttargetObjectGet0 : Automation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.targetObject;
			yield break;
		}

	}

	[Automation( "Serialized Object/Get Target Objects" )]
	class SerializedObjecttargetObjectsGet1 : Automation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = Instance.targetObjects;
			yield break;
		}

	}

	[Automation( "Serialized Object/Get Is Editing Multiple Objects" )]
	class SerializedObjectisEditingMultipleObjectsGet2 : ConditionalAutomation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isEditingMultipleObjects;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Object/Update" )]
	class SerializedObjectUpdate0 : Automation {

		public UnityEditor.SerializedObject Instance;

		public override IEnumerator Execute() {
			Instance.Update();
			yield break;
		}

	}

	[Automation( "Serialized Object/Set Is Different Cache Dirty" )]
	class SerializedObjectSetIsDifferentCacheDirty1 : Automation {

		public UnityEditor.SerializedObject Instance;

		public override IEnumerator Execute() {
			Instance.SetIsDifferentCacheDirty();
			yield break;
		}

	}

	[Automation( "Serialized Object/Update If Dirty Or Script" )]
	class SerializedObjectUpdateIfDirtyOrScript2 : Automation {

		public UnityEditor.SerializedObject Instance;

		public override IEnumerator Execute() {
			Instance.UpdateIfDirtyOrScript();
			yield break;
		}

	}

	[Automation( "Serialized Object/Get Iterator" )]
	class SerializedObjectGetIterator3 : Automation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public UnityEditor.SerializedProperty Result;

		public override IEnumerator Execute() {
			Result = Instance.GetIterator();
			yield break;
		}

	}

	[Automation( "Serialized Object/Find Property" )]
	class SerializedObjectFindProperty4 : Automation {

		public UnityEditor.SerializedObject Instance;
		public System.String propertyPath;
		[ReadOnly]
		public UnityEditor.SerializedProperty Result;

		public override IEnumerator Execute() {
			Result = Instance.FindProperty(propertyPath);
			yield break;
		}

	}

	[Automation( "Serialized Object/Apply Modified Properties" )]
	class SerializedObjectApplyModifiedProperties5 : ConditionalAutomation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.ApplyModifiedProperties();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Object/Apply Modified Properties Without Undo" )]
	class SerializedObjectApplyModifiedPropertiesWithoutUndo6 : ConditionalAutomation {

		public UnityEditor.SerializedObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.ApplyModifiedPropertiesWithoutUndo();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Object/Copy From Serialized Property" )]
	class SerializedObjectCopyFromSerializedProperty7 : Automation {

		public UnityEditor.SerializedObject Instance;
		public UnityEditor.SerializedProperty prop;

		public override IEnumerator Execute() {
			Instance.CopyFromSerializedProperty(prop);
			yield break;
		}

	}


#pragma warning restore 0649
}
