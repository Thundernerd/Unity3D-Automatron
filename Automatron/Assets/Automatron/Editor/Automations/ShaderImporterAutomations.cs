#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Shader Importer/Get Shader" )]
	class ShaderImporterGetShader0 : Automation {

		public UnityEditor.ShaderImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Shader Result;

		public override IEnumerator Execute() {
			Result = Instance.GetShader();
			yield break;
		}

	}

	[Automation( "Shader Importer/Set Default Textures" )]
	class ShaderImporterSetDefaultTextures1 : Automation {

		public UnityEditor.ShaderImporter Instance;
		public System.String[] name;
		public UnityEngine.Texture[] textures;

		public override IEnumerator Execute() {
			Instance.SetDefaultTextures(name,textures);
			yield break;
		}

	}

	[Automation( "Shader Importer/Get Default Texture" )]
	class ShaderImporterGetDefaultTexture2 : Automation {

		public UnityEditor.ShaderImporter Instance;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDefaultTexture(name);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif