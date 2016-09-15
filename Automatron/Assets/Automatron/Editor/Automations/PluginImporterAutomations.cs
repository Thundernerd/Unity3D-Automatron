using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Plugin Importer/Get Is Native Plugin" )]
	class PluginImporterisNativePluginGet0 : ConditionalAutomation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isNativePlugin;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Plugin Importer/Set Compatible With Any Platform" )]
	class PluginImporterSetCompatibleWithAnyPlatform0 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithAnyPlatform(enable);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Compatible With Any Platform" )]
	class PluginImporterGetCompatibleWithAnyPlatform1 : ConditionalAutomation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithAnyPlatform();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Plugin Importer/Set Compatible With Editor" )]
	class PluginImporterSetCompatibleWithEditor2 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithEditor(enable);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Compatible With Editor" )]
	class PluginImporterGetCompatibleWithEditor3 : ConditionalAutomation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithEditor();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Plugin Importer/Set Compatible With Platform" )]
	class PluginImporterSetCompatibleWithPlatform4 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithPlatform(platform,enable);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Compatible With Platform" )]
	class PluginImporterGetCompatibleWithPlatform5 : ConditionalAutomation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithPlatform(platform);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Plugin Importer/Set Platform Data" )]
	class PluginImporterSetPlatformData6 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			Instance.SetPlatformData(platform,key,value);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Platform Data" )]
	class PluginImporterGetPlatformData7 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		public System.String key;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPlatformData(platform,key);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Set Editor Data" )]
	class PluginImporterSetEditorData8 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			Instance.SetEditorData(key,value);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Editor Data" )]
	class PluginImporterGetEditorData9 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String key;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.GetEditorData(key);
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get All Importers" )]
	class PluginImporterGetAllImporters10 : Automation {

		[ReadOnly]
		public UnityEditor.PluginImporter[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PluginImporter.GetAllImporters();
			yield break;
		}

	}

	[Automation( "Plugin Importer/Get Importers" )]
	class PluginImporterGetImporters11 : Automation {

		public UnityEditor.BuildTarget platform;
		[ReadOnly]
		public UnityEditor.PluginImporter[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PluginImporter.GetImporters(platform);
			yield break;
		}

	}


#pragma warning restore 0649
}
