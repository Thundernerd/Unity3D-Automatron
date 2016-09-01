using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Undo/Get Will Flush Undo Record" )]
	class UndowillFlushUndoRecordGet0 : Automation {

		[ReadOnly]
		public UnityEditor.Undo.WillFlushUndoRecord Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Undo.willFlushUndoRecord;
			yield break;
		}

	}

	[Automation( "Undo/Set Will Flush Undo Record" )]
	class UndowillFlushUndoRecordSet0 : Automation {

		public UnityEditor.Undo.WillFlushUndoRecord Value;

		public override IEnumerator Execute() {
			UnityEditor.Undo.willFlushUndoRecord = Value;
			yield break;
		}

	}

	[Automation( "Undo/Register Complete Object Undo" )]
	class UndoRegisterCompleteObjectUndo0 : Automation {

		public UnityEngine.Object objectToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RegisterCompleteObjectUndo(objectToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Register Complete Objects Undo" )]
	class UndoRegisterCompleteObjectUndo1 : Automation {

		public UnityEngine.Object[] objectsToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RegisterCompleteObjectUndo(objectsToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Set Transform Parent" )]
	class UndoSetTransformParent2 : Automation {

		public UnityEngine.Transform transform;
		public UnityEngine.Transform newParent;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.SetTransformParent(transform,newParent,name);
			yield break;
		}

	}

	[Automation( "Undo/Move Game Object To Scene" )]
	class UndoMoveGameObjectToScene3 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.SceneManagement.Scene scene;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.MoveGameObjectToScene(go,scene,name);
			yield break;
		}

	}

	[Automation( "Undo/Register Created Object Undo" )]
	class UndoRegisterCreatedObjectUndo4 : Automation {

		public UnityEngine.Object objectToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RegisterCreatedObjectUndo(objectToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Destroy Object Immediate" )]
	class UndoDestroyObjectImmediate5 : Automation {

		public UnityEngine.Object objectToUndo;

		public override IEnumerator Execute() {
			UnityEditor.Undo.DestroyObjectImmediate(objectToUndo);
			yield break;
		}

	}

	[Automation( "Undo/Add Component" )]
	class UndoAddComponent6 : Automation {

		public UnityEngine.GameObject gameObject;
		public System.Type type;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Undo.AddComponent(gameObject,type);
			yield break;
		}

	}

	[Automation( "Undo/Register Full Object Hierarchy Undo" )]
	class UndoRegisterFullObjectHierarchyUndo7 : Automation {

		public UnityEngine.Object objectToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RegisterFullObjectHierarchyUndo(objectToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Record Object" )]
	class UndoRecordObject8 : Automation {

		public UnityEngine.Object objectToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RecordObject(objectToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Record Objects" )]
	class UndoRecordObjects9 : Automation {

		public UnityEngine.Object[] objectsToUndo;
		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RecordObjects(objectsToUndo,name);
			yield break;
		}

	}

	[Automation( "Undo/Clear Undo" )]
	class UndoClearUndo10 : Automation {

		public UnityEngine.Object identifier;

		public override IEnumerator Execute() {
			UnityEditor.Undo.ClearUndo(identifier);
			yield break;
		}

	}

	[Automation( "Undo/Perform Undo" )]
	class UndoPerformUndo11 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Undo.PerformUndo();
			yield break;
		}

	}

	[Automation( "Undo/Perform Redo" )]
	class UndoPerformRedo12 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Undo.PerformRedo();
			yield break;
		}

	}

	[Automation( "Undo/Increment Current Group" )]
	class UndoIncrementCurrentGroup13 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Undo.IncrementCurrentGroup();
			yield break;
		}

	}

	[Automation( "Undo/Get Current Group" )]
	class UndoGetCurrentGroup14 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Undo.GetCurrentGroup();
			yield break;
		}

	}

	[Automation( "Undo/Get Current Group Name" )]
	class UndoGetCurrentGroupName15 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Undo.GetCurrentGroupName();
			yield break;
		}

	}

	[Automation( "Undo/Set Current Group Name" )]
	class UndoSetCurrentGroupName16 : Automation {

		public System.String name;

		public override IEnumerator Execute() {
			UnityEditor.Undo.SetCurrentGroupName(name);
			yield break;
		}

	}

	[Automation( "Undo/Revert All In Current Group" )]
	class UndoRevertAllInCurrentGroup17 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Undo.RevertAllInCurrentGroup();
			yield break;
		}

	}

	[Automation( "Undo/Revert All Down To Group" )]
	class UndoRevertAllDownToGroup18 : Automation {

		public System.Int32 group;

		public override IEnumerator Execute() {
			UnityEditor.Undo.RevertAllDownToGroup(group);
			yield break;
		}

	}

	[Automation( "Undo/Collapse Undo Operations" )]
	class UndoCollapseUndoOperations19 : Automation {

		public System.Int32 groupIndex;

		public override IEnumerator Execute() {
			UnityEditor.Undo.CollapseUndoOperations(groupIndex);
			yield break;
		}

	}

	[Automation( "Undo/Flush Undo Record Objects" )]
	class UndoFlushUndoRecordObjects20 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Undo.FlushUndoRecordObjects();
			yield break;
		}

	}


#pragma warning restore 0649
}
