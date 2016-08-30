using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Object/Destroy Immediate" )]
	class ObjectDestroyImmediate3 : Automation {

		public UnityEngine.Object obj;

		public override IEnumerator Execute() {
			UnityEngine.Object.DestroyImmediate(obj);
			yield break;
		}

	}

	[Automation( "Object/Find Objects Of Type" )]
	class ObjectFindObjectsOfType4 : Automation {

		public System.Type type;
		[ReadOnly]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Object.FindObjectsOfType(type);
			yield break;
		}

	}

	[Automation( "Object/Find Object Of Type" )]
	class ObjectFindObjectOfType10 : Automation {

		public System.Type type;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Object.FindObjectOfType(type);
			yield break;
		}

	}


#pragma warning restore 0649
}
