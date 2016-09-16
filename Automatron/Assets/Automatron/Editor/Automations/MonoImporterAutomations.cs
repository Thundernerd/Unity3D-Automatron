using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mono Importer/Set Default References" )]
	class MonoImporterSetDefaultReferences0 : Automation {

		public UnityEditor.MonoImporter Instance;
		public System.String[] name;
		public UnityEngine.Object[] target;

		public override IEnumerator Execute() {
			Instance.SetDefaultReferences(name,target);
			yield break;
		}

	}

	[Automation( "Mono Importer/Get All Runtime Mono Scripts" )]
	class MonoImporterGetAllRuntimeMonoScripts1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.MonoScript[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MonoImporter.GetAllRuntimeMonoScripts();
			yield break;
		}

	}

	[Automation( "Mono Importer/Set Execution Order" )]
	class MonoImporterSetExecutionOrder2 : Automation {

		public UnityEditor.MonoScript script;
		public System.Int32 order;

		public override IEnumerator Execute() {
			UnityEditor.MonoImporter.SetExecutionOrder(script,order);
			yield break;
		}

	}

	[Automation( "Mono Importer/Get Execution Order" )]
	class MonoImporterGetExecutionOrder3 : Automation {

		public UnityEditor.MonoScript script;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MonoImporter.GetExecutionOrder(script);
			yield break;
		}

	}

	[Automation( "Mono Importer/Get Script" )]
	class MonoImporterGetScript4 : Automation {

		public UnityEditor.MonoImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.MonoScript Result;

		public override IEnumerator Execute() {
			Result = Instance.GetScript();
			yield break;
		}

	}

	[Automation( "Mono Importer/Get Default Reference" )]
	class MonoImporterGetDefaultReference5 : Automation {

		public UnityEditor.MonoImporter Instance;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDefaultReference(name);
			yield break;
		}

	}


#pragma warning restore 0649
}
