using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Lightmap Editor Settings/Get Max Atlas Width" )]
	class LightmapEditorSettingsmaxAtlasWidthGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.maxAtlasWidth;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Max Atlas Width" )]
	class LightmapEditorSettingsmaxAtlasWidthSet0 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.maxAtlasWidth = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Max Atlas Height" )]
	class LightmapEditorSettingsmaxAtlasHeightGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.maxAtlasHeight;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Max Atlas Height" )]
	class LightmapEditorSettingsmaxAtlasHeightSet1 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.maxAtlasHeight = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Resolution" )]
	class LightmapEditorSettingsresolutionGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.resolution;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Resolution" )]
	class LightmapEditorSettingsresolutionSet2 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.resolution = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Bake Resolution" )]
	class LightmapEditorSettingsbakeResolutionGet3 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.bakeResolution;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Bake Resolution" )]
	class LightmapEditorSettingsbakeResolutionSet3 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.bakeResolution = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Texture Compression" )]
	class LightmapEditorSettingstextureCompressionGet4 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.LightmapEditorSettings.textureCompression;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmap Editor Settings/Set Texture Compression" )]
	class LightmapEditorSettingstextureCompressionSet4 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.textureCompression = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Reflection Cubemap Compression" )]
	class LightmapEditorSettingsreflectionCubemapCompressionGet5 : Automation {

		[ReadOnly]
		public UnityEngine.Rendering.ReflectionCubemapCompression Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.reflectionCubemapCompression;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Reflection Cubemap Compression" )]
	class LightmapEditorSettingsreflectionCubemapCompressionSet5 : Automation {

		public UnityEngine.Rendering.ReflectionCubemapCompression Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.reflectionCubemapCompression = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Ao Max Distance" )]
	class LightmapEditorSettingsaoMaxDistanceGet6 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.aoMaxDistance;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Ao Max Distance" )]
	class LightmapEditorSettingsaoMaxDistanceSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.aoMaxDistance = Value;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Get Padding" )]
	class LightmapEditorSettingspaddingGet7 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.LightmapEditorSettings.padding;
			yield break;
		}

	}

	[Automation( "Lightmap Editor Settings/Set Padding" )]
	class LightmapEditorSettingspaddingSet7 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.LightmapEditorSettings.padding = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
