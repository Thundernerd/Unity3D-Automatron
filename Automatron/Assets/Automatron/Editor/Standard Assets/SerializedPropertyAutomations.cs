using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Serialized Property/Get Serialized Object" )]
	class SerializedPropertyserializedObjectGet0 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEditor.SerializedObject Result;

		public override IEnumerator Execute() {
			Result = Instance.serializedObject;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Has Multiple Different Values" )]
	class SerializedPropertyhasMultipleDifferentValuesGet1 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasMultipleDifferentValues;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Display Name" )]
	class SerializedPropertydisplayNameGet2 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.displayName;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Name" )]
	class SerializedPropertynameGet3 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.name;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Type" )]
	class SerializedPropertytypeGet4 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.type;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Tooltip" )]
	class SerializedPropertytooltipGet5 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.tooltip;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Depth" )]
	class SerializedPropertydepthGet6 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Property Path" )]
	class SerializedPropertypropertyPathGet7 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.propertyPath;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Editable" )]
	class SerializedPropertyeditableGet8 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.editable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Is Animated" )]
	class SerializedPropertyisAnimatedGet9 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isAnimated;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Is Expanded" )]
	class SerializedPropertyisExpandedGet10 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isExpanded;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Set Is Expanded" )]
	class SerializedPropertyisExpandedSet10 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isExpanded = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Has Children" )]
	class SerializedPropertyhasChildrenGet11 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasChildren;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Has Visible Children" )]
	class SerializedPropertyhasVisibleChildrenGet12 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasVisibleChildren;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Is Instantiated Prefab" )]
	class SerializedPropertyisInstantiatedPrefabGet13 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isInstantiatedPrefab;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Prefab Override" )]
	class SerializedPropertyprefabOverrideGet14 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.prefabOverride;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Set Prefab Override" )]
	class SerializedPropertyprefabOverrideSet14 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.prefabOverride = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Property Type" )]
	class SerializedPropertypropertyTypeGet15 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEditor.SerializedPropertyType Result;

		public override IEnumerator Execute() {
			Result = Instance.propertyType;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Int Value" )]
	class SerializedPropertyintValueGet16 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.intValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Int Value" )]
	class SerializedPropertyintValueSet16 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.intValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Long Value" )]
	class SerializedPropertylongValueGet17 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.longValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Long Value" )]
	class SerializedPropertylongValueSet17 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int64 Value;

		public override IEnumerator Execute() {
			Instance.longValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Bool Value" )]
	class SerializedPropertyboolValueGet18 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.boolValue;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Set Bool Value" )]
	class SerializedPropertyboolValueSet18 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.boolValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Float Value" )]
	class SerializedPropertyfloatValueGet19 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.floatValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Float Value" )]
	class SerializedPropertyfloatValueSet19 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.floatValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Double Value" )]
	class SerializedPropertydoubleValueGet20 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.doubleValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Double Value" )]
	class SerializedPropertydoubleValueSet20 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Double Value;

		public override IEnumerator Execute() {
			Instance.doubleValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get String Value" )]
	class SerializedPropertystringValueGet21 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.stringValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set String Value" )]
	class SerializedPropertystringValueSet21 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.stringValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Color Value" )]
	class SerializedPropertycolorValueGet22 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.colorValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Color Value" )]
	class SerializedPropertycolorValueSet22 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.colorValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Animation Curve Value" )]
	class SerializedPropertyanimationCurveValueGet23 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.AnimationCurve Result;

		public override IEnumerator Execute() {
			Result = Instance.animationCurveValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Animation Curve Value" )]
	class SerializedPropertyanimationCurveValueSet23 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.AnimationCurve Value;

		public override IEnumerator Execute() {
			Instance.animationCurveValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Object Reference Value" )]
	class SerializedPropertyobjectReferenceValueGet24 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.objectReferenceValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Object Reference Value" )]
	class SerializedPropertyobjectReferenceValueSet24 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Object Value;

		public override IEnumerator Execute() {
			Instance.objectReferenceValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Object Reference Instance ID Value" )]
	class SerializedPropertyobjectReferenceInstanceIDValueGet25 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.objectReferenceInstanceIDValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Object Reference Instance ID Value" )]
	class SerializedPropertyobjectReferenceInstanceIDValueSet25 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.objectReferenceInstanceIDValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Enum Value Index" )]
	class SerializedPropertyenumValueIndexGet26 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.enumValueIndex;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Enum Value Index" )]
	class SerializedPropertyenumValueIndexSet26 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.enumValueIndex = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Enum Names" )]
	class SerializedPropertyenumNamesGet27 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enumNames;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Enum Display Names" )]
	class SerializedPropertyenumDisplayNamesGet28 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enumDisplayNames;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Vector 2 Value" )]
	class SerializedPropertyvector2ValueGet29 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.vector2Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Vector 2 Value" )]
	class SerializedPropertyvector2ValueSet29 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.vector2Value = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Vector 3 Value" )]
	class SerializedPropertyvector3ValueGet30 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.vector3Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Vector 3 Value" )]
	class SerializedPropertyvector3ValueSet30 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.vector3Value = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Vector 4 Value" )]
	class SerializedPropertyvector4ValueGet31 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.vector4Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Vector 4 Value" )]
	class SerializedPropertyvector4ValueSet31 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.vector4Value = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Quaternion Value" )]
	class SerializedPropertyquaternionValueGet32 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.quaternionValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Quaternion Value" )]
	class SerializedPropertyquaternionValueSet32 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.quaternionValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Rect Value" )]
	class SerializedPropertyrectValueGet33 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.rectValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Rect Value" )]
	class SerializedPropertyrectValueSet33 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.rectValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Bounds Value" )]
	class SerializedPropertyboundsValueGet34 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.boundsValue;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Bounds Value" )]
	class SerializedPropertyboundsValueSet34 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public UnityEngine.Bounds Value;

		public override IEnumerator Execute() {
			Instance.boundsValue = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Is Array" )]
	class SerializedPropertyisArrayGet35 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isArray;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Get Array Size" )]
	class SerializedPropertyarraySizeGet36 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.arraySize;
			yield break;
		}

	}

	[Automation( "Serialized Property/Set Array Size" )]
	class SerializedPropertyarraySizeSet36 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.arraySize = Value;
			yield break;
		}

	}

	[Automation( "Serialized Property/Next" )]
	class SerializedPropertyNext0 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean enterChildren;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.Next(enterChildren);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Next Visible" )]
	class SerializedPropertyNextVisible1 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean enterChildren;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.NextVisible(enterChildren);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Serialized Property/Reset" )]
	class SerializedPropertyReset2 : Automation {

		public UnityEditor.SerializedProperty Instance;

		public override IEnumerator Execute() {
			Instance.Reset();
			yield break;
		}

	}

	[Automation( "Serialized Property/Count Remaining" )]
	class SerializedPropertyCountRemaining3 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.CountRemaining();
			yield break;
		}

	}

	[Automation( "Serialized Property/Count In Property" )]
	class SerializedPropertyCountInProperty4 : Automation {

		public UnityEditor.SerializedProperty Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.CountInProperty();
			yield break;
		}

	}

	[Automation( "Serialized Property/Find Property Relative" )]
	class SerializedPropertyFindPropertyRelative5 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.String relativePropertyPath;
		[ReadOnly]
		public UnityEditor.SerializedProperty Result;

		public override IEnumerator Execute() {
			Result = Instance.FindPropertyRelative(relativePropertyPath);
			yield break;
		}

	}

	[Automation( "Serialized Property/Get End Property" )]
	class SerializedPropertyGetEndProperty7 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Boolean includeInvisible;
		[ReadOnly]
		public UnityEditor.SerializedProperty Result;

		public override IEnumerator Execute() {
			Result = Instance.GetEndProperty(includeInvisible);
			yield break;
		}

	}

	[Automation( "Serialized Property/Get Array Element At Index" )]
	class SerializedPropertyGetArrayElementAtIndex8 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 index;
		[ReadOnly]
		public UnityEditor.SerializedProperty Result;

		public override IEnumerator Execute() {
			Result = Instance.GetArrayElementAtIndex(index);
			yield break;
		}

	}

	[Automation( "Serialized Property/Insert Array Element At Index" )]
	class SerializedPropertyInsertArrayElementAtIndex9 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.InsertArrayElementAtIndex(index);
			yield break;
		}

	}

	[Automation( "Serialized Property/Delete Array Element At Index" )]
	class SerializedPropertyDeleteArrayElementAtIndex10 : Automation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.DeleteArrayElementAtIndex(index);
			yield break;
		}

	}

	[Automation( "Serialized Property/Clear Array" )]
	class SerializedPropertyClearArray11 : Automation {

		public UnityEditor.SerializedProperty Instance;

		public override IEnumerator Execute() {
			Instance.ClearArray();
			yield break;
		}

	}

	[Automation( "Serialized Property/Move Array Element" )]
	class SerializedPropertyMoveArrayElement12 : ConditionalAutomation {

		public UnityEditor.SerializedProperty Instance;
		public System.Int32 srcIndex;
		public System.Int32 dstIndex;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.MoveArrayElement(srcIndex,dstIndex);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
