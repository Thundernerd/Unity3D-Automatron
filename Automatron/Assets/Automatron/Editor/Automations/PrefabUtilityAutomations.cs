#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Prefab Utility/Get Prefab Parent" )]
	class PrefabUtilityGetPrefabParent0 : Automation {

		public UnityEngine.Object source;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabParent(source);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Get Prefab Object" )]
	class PrefabUtilityGetPrefabObject1 : Automation {

		public UnityEngine.Object targetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabObject(targetObject);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Get Property Modifications" )]
	class PrefabUtilityGetPropertyModifications2 : Automation {

		public UnityEngine.Object targetPrefab;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.PropertyModification[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPropertyModifications(targetPrefab);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Set Property Modifications" )]
	class PrefabUtilitySetPropertyModifications3 : Automation {

		public UnityEngine.Object targetPrefab;
		public UnityEditor.PropertyModification[] modifications;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.SetPropertyModifications(targetPrefab,modifications);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Instantiate Attached Asset" )]
	class PrefabUtilityInstantiateAttachedAsset4 : Automation {

		public UnityEngine.Object targetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.InstantiateAttachedAsset(targetObject);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Record Prefab Instance Property Modifications" )]
	class PrefabUtilityRecordPrefabInstancePropertyModifications5 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(targetObject);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Merge All Prefab Instances" )]
	class PrefabUtilityMergeAllPrefabInstances6 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.MergeAllPrefabInstances(targetObject);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Disconnect Prefab Instance" )]
	class PrefabUtilityDisconnectPrefabInstance7 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.DisconnectPrefabInstance(targetObject);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Instantiate Prefab" )]
	class PrefabUtilityInstantiatePrefab8 : Automation {

		public UnityEngine.Object target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.InstantiatePrefab(target);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Create Empty Prefab" )]
	class PrefabUtilityCreateEmptyPrefab9 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.CreateEmptyPrefab(path);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Create Prefab" )]
	class PrefabUtilityCreatePrefab10 : Automation {

		public System.String path;
		public UnityEngine.GameObject go;
		public UnityEditor.ReplacePrefabOptions options;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.CreatePrefab(path,go,options);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Replace Prefab" )]
	class PrefabUtilityReplacePrefab11 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.Object targetPrefab;
		public UnityEditor.ReplacePrefabOptions options;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ReplacePrefab(go,targetPrefab,options);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Connect Game Object To Prefab" )]
	class PrefabUtilityConnectGameObjectToPrefab12 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.GameObject sourcePrefab;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ConnectGameObjectToPrefab(go,sourcePrefab);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Find Root Game Object With Same Parent Prefab" )]
	class PrefabUtilityFindRootGameObjectWithSameParentPrefab13 : Automation {

		public UnityEngine.GameObject target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindRootGameObjectWithSameParentPrefab(target);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Find Valid Upload Prefab Instance Root" )]
	class PrefabUtilityFindValidUploadPrefabInstanceRoot14 : Automation {

		public UnityEngine.GameObject target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindValidUploadPrefabInstanceRoot(target);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Reconnect To Last Prefab" )]
	class PrefabUtilityReconnectToLastPrefab15 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ReconnectToLastPrefab(go);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Prefab Utility/Reset To Prefab State" )]
	class PrefabUtilityResetToPrefabState16 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ResetToPrefabState(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Prefab Utility/Is Component Added To Prefab Instance" )]
	class PrefabUtilityIsComponentAddedToPrefabInstance17 : ConditionalAutomation {

		public UnityEngine.Object source;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.IsComponentAddedToPrefabInstance(source);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Prefab Utility/Revert Prefab Instance" )]
	class PrefabUtilityRevertPrefabInstance18 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.RevertPrefabInstance(go);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Prefab Utility/Get Prefab Type" )]
	class PrefabUtilityGetPrefabType19 : Automation {

		public UnityEngine.Object target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.PrefabType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabType(target);
			yield break;
		}

	}

	[Automation( "Prefab Utility/Find Prefab Root" )]
	class PrefabUtilityFindPrefabRoot20 : Automation {

		public UnityEngine.GameObject source;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindPrefabRoot(source);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif