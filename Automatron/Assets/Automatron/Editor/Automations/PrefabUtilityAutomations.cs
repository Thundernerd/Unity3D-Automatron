using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Prefab Utility/Get Prefab Parent" )]
	class PrefabUtilityGetPrefabParent0 : Automation {

		public UnityEngine.Object source;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabParent(source);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Get Prefab Object" )]
	class PrefabUtilityGetPrefabObject1 : Automation {

		public UnityEngine.Object targetObject;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabObject(targetObject);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Instantiate Attached Asset" )]
	class PrefabUtilityInstantiateAttachedAsset2 : Automation {

		public UnityEngine.Object targetObject;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.InstantiateAttachedAsset(targetObject);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Record Prefab Instance Property Modifications" )]
	class PrefabUtilityRecordPrefabInstancePropertyModifications3 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(targetObject);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Merge All Prefab Instances" )]
	class PrefabUtilityMergeAllPrefabInstances4 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.MergeAllPrefabInstances(targetObject);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Disconnect Prefab Instance" )]
	class PrefabUtilityDisconnectPrefabInstance5 : Automation {

		public UnityEngine.Object targetObject;

		public override IEnumerator Execute() {
			UnityEditor.PrefabUtility.DisconnectPrefabInstance(targetObject);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Instantiate Prefab" )]
	class PrefabUtilityInstantiatePrefab6 : Automation {

		public UnityEngine.Object target;
		public UnityEngine.SceneManagement.Scene destinationScene;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.InstantiatePrefab(target,destinationScene);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Create Empty Prefab" )]
	class PrefabUtilityCreateEmptyPrefab7 : Automation {

		public System.String path;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.CreateEmptyPrefab(path);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Create Prefab" )]
	class PrefabUtilityCreatePrefab8 : Automation {

		public System.String path;
		public UnityEngine.GameObject go;
		public UnityEditor.ReplacePrefabOptions options;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.CreatePrefab(path,go,options);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Replace Prefab" )]
	class PrefabUtilityReplacePrefab9 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.Object targetPrefab;
		public UnityEditor.ReplacePrefabOptions options;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ReplacePrefab(go,targetPrefab,options);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Connect Game Object To Prefab" )]
	class PrefabUtilityConnectGameObjectToPrefab10 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.GameObject sourcePrefab;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.ConnectGameObjectToPrefab(go,sourcePrefab);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Find Root Game Object With Same Parent Prefab" )]
	class PrefabUtilityFindRootGameObjectWithSameParentPrefab11 : Automation {

		public UnityEngine.GameObject target;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindRootGameObjectWithSameParentPrefab(target);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Find Valid Upload Prefab Instance Root" )]
	class PrefabUtilityFindValidUploadPrefabInstanceRoot12 : Automation {

		public UnityEngine.GameObject target;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindValidUploadPrefabInstanceRoot(target);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Reconnect To Last Prefab" )]
	class PrefabUtilityReconnectToLastPrefab13 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PrefabUtility.ReconnectToLastPrefab(go);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Prefab Utility/Reset To Prefab State" )]
	class PrefabUtilityResetToPrefabState14 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PrefabUtility.ResetToPrefabState(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Prefab Utility/Is Component Added To Prefab Instance" )]
	class PrefabUtilityIsComponentAddedToPrefabInstance15 : ConditionalAutomation {

		public UnityEngine.Object source;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PrefabUtility.IsComponentAddedToPrefabInstance(source);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Prefab Utility/Revert Prefab Instance" )]
	class PrefabUtilityRevertPrefabInstance16 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PrefabUtility.RevertPrefabInstance(go);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Prefab Utility/Get Prefab Type" )]
	class PrefabUtilityGetPrefabType17 : Automation {

		public UnityEngine.Object target;
		[ReadOnly]
		public UnityEditor.PrefabType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.GetPrefabType(target);
			yield break;
		}

	}

	[Automation( "Utilities/Prefab Utility/Find Prefab Root" )]
	class PrefabUtilityFindPrefabRoot18 : Automation {

		public UnityEngine.GameObject source;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PrefabUtility.FindPrefabRoot(source);
			yield break;
		}

	}


#pragma warning restore 0649
}
