using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Plugin Importer/Get Is Native Plugin" )]
	class PluginImporterisNativePluginGet0 : Automation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isNativePlugin;
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Compatible With Any Platform" )]
	class PluginImporterSetCompatibleWithAnyPlatform0 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithAnyPlatform(enable);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Compatible With Any Platform" )]
	class PluginImporterGetCompatibleWithAnyPlatform1 : Automation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithAnyPlatform();
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Compatible With Editor" )]
	class PluginImporterSetCompatibleWithEditor2 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithEditor(enable);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Compatible With Editor" )]
	class PluginImporterGetCompatibleWithEditor3 : Automation {

		public UnityEditor.PluginImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithEditor();
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Compatible With Platform" )]
	class PluginImporterSetCompatibleWithPlatform4 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithPlatform(platform,enable);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Compatible With Platform" )]
	class PluginImporterGetCompatibleWithPlatform5 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithPlatform(platform);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Compatible With Platform" )]
	class PluginImporterSetCompatibleWithPlatform6 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String platformName;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			Instance.SetCompatibleWithPlatform(platformName,enable);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Compatible With Platform" )]
	class PluginImporterGetCompatibleWithPlatform7 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String platformName;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCompatibleWithPlatform(platformName);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Platform Data" )]
	class PluginImporterSetPlatformData8 : Automation {

		public UnityEditor.PluginImporter Instance;
		public UnityEditor.BuildTarget platform;
		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			Instance.SetPlatformData(platform,key,value);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Platform Data" )]
	class PluginImporterGetPlatformData9 : Automation {

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

	[Automation( "Importers/Plugin Importer/Set Platform Data" )]
	class PluginImporterSetPlatformData10 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String platformName;
		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			Instance.SetPlatformData(platformName,key,value);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Platform Data" )]
	class PluginImporterGetPlatformData11 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String platformName;
		public System.String key;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPlatformData(platformName,key);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Set Editor Data" )]
	class PluginImporterSetEditorData12 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			Instance.SetEditorData(key,value);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Editor Data" )]
	class PluginImporterGetEditorData13 : Automation {

		public UnityEditor.PluginImporter Instance;
		public System.String key;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.GetEditorData(key);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get All Importers" )]
	class PluginImporterGetAllImporters14 : Automation {

		[ReadOnly]
		public UnityEditor.PluginImporter[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PluginImporter.GetAllImporters();
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Importers" )]
	class PluginImporterGetImporters15 : Automation {

		public System.String platformName;
		[ReadOnly]
		public UnityEditor.PluginImporter[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PluginImporter.GetImporters(platformName);
			yield break;
		}

	}

	[Automation( "Importers/Plugin Importer/Get Importers" )]
	class PluginImporterGetImporters16 : Automation {

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
