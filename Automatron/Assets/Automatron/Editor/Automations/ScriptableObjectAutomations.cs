using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Scriptable Object/Create Instance By Name" )]
	class ScriptableObjectCreateInstance0 : Automation {

		public System.String className;
		[ReadOnly]
		public UnityEngine.ScriptableObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ScriptableObject.CreateInstance(className);
			yield break;
		}

	}

	[Automation( "Scriptable Object/Create Instance By Type" )]
	class ScriptableObjectCreateInstance1 : Automation {

		public System.Type type;
		[ReadOnly]
		public UnityEngine.ScriptableObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ScriptableObject.CreateInstance(type);
			yield break;
		}

	}


#pragma warning restore 0649
}
