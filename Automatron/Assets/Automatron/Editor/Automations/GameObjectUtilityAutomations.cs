using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Game Object Utility/Get Static Editor Flags" )]
	class GameObjectUtilityGetStaticEditorFlags0 : Automation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.StaticEditorFlags Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.GetStaticEditorFlags(go);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Are Static Editor Flags Set" )]
	class GameObjectUtilityAreStaticEditorFlagsSet1 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		public UnityEditor.StaticEditorFlags flags;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.AreStaticEditorFlagsSet(go,flags);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Game Object Utility/Set Static Editor Flags" )]
	class GameObjectUtilitySetStaticEditorFlags2 : Automation {

		public UnityEngine.GameObject go;
		public UnityEditor.StaticEditorFlags flags;

		public override IEnumerator Execute() {
			UnityEditor.GameObjectUtility.SetStaticEditorFlags(go,flags);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Get Nav Mesh Area" )]
	class GameObjectUtilityGetNavMeshArea3 : Automation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.GetNavMeshArea(go);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Get Nav Mesh Area From Name" )]
	class GameObjectUtilityGetNavMeshAreaFromName4 : Automation {

		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.GetNavMeshAreaFromName(name);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Set Nav Mesh Area" )]
	class GameObjectUtilitySetNavMeshArea5 : Automation {

		public UnityEngine.GameObject go;
		public System.Int32 areaIndex;

		public override IEnumerator Execute() {
			UnityEditor.GameObjectUtility.SetNavMeshArea(go,areaIndex);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Get Nav Mesh Area Names" )]
	class GameObjectUtilityGetNavMeshAreaNames6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.GetNavMeshAreaNames();
			yield break;
		}

	}

	[Automation( "Game Object Utility/Get Unique Name For Sibling" )]
	class GameObjectUtilityGetUniqueNameForSibling7 : Automation {

		public UnityEngine.Transform parent;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.GameObjectUtility.GetUniqueNameForSibling(parent,name);
			yield break;
		}

	}

	[Automation( "Game Object Utility/Set Parent And Align" )]
	class GameObjectUtilitySetParentAndAlign8 : Automation {

		public UnityEngine.GameObject child;
		public UnityEngine.GameObject parent;

		public override IEnumerator Execute() {
			UnityEditor.GameObjectUtility.SetParentAndAlign(child,parent);
			yield break;
		}

	}


#pragma warning restore 0649
}
