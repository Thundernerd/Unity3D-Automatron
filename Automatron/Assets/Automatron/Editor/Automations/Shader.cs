using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Generated/Shader/Get Is Supported" )]
	class ShaderisSupportedGet0 : Automation {

		public UnityEngine.Shader Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isSupported;
			yield break;
		}

	}

	[Automation( "Generated/Shader/Get Maximum LOD" )]
	class ShadermaximumLODGet1 : Automation {

		public UnityEngine.Shader Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.maximumLOD;
			yield break;
		}

	}

	[Automation( "Generated/Shader/Set Maximum LOD" )]
	class ShadermaximumLODSet1 : Automation {

		public UnityEngine.Shader Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.maximumLOD = Value;
			yield break;
		}

	}

	[Automation( "Generated/Shader/Get Global Maximum LOD" )]
	class ShaderglobalMaximumLODGet2 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.globalMaximumLOD;
			yield break;
		}

	}

	[Automation( "Generated/Shader/Set Global Maximum LOD" )]
	class ShaderglobalMaximumLODSet2 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.globalMaximumLOD = Value;
			yield break;
		}

	}

	[Automation( "Generated/Shader/Get Render Queue" )]
	class ShaderrenderQueueGet3 : Automation {

		public UnityEngine.Shader Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.renderQueue;
			yield break;
		}

	}
	[Automation( "Shader/Find" )]
	class ShaderFind0 : Automation {

		public System.String name;
		[ReadOnly]
		public UnityEngine.Shader Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.Find(name);
			yield break;
		}

	}

	[Automation( "Shader/Enable Keyword" )]
	class ShaderEnableKeyword1 : Automation {

		public System.String keyword;

		public override IEnumerator Execute() {
			UnityEngine.Shader.EnableKeyword(keyword);
			yield break;
		}

	}

	[Automation( "Shader/Disable Keyword" )]
	class ShaderDisableKeyword2 : Automation {

		public System.String keyword;

		public override IEnumerator Execute() {
			UnityEngine.Shader.DisableKeyword(keyword);
			yield break;
		}

	}

	[Automation( "Generated/Shader/Is Keyword Enabled" )]
	class ShaderIsKeywordEnabled3 : ConditionalAutomation {

		public System.String keyword;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Shader.IsKeywordEnabled(keyword);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Shader/Set Global Color" )]
	class ShaderSetGlobalColor4 : Automation {

		public System.String propertyName;
		public UnityEngine.Color color;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalColor(propertyName,color);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Color (ID)" )]
	class ShaderSetGlobalColor5 : Automation {

		public System.Int32 nameID;
		public UnityEngine.Color color;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalColor(nameID,color);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Vector" )]
	class ShaderSetGlobalVector6 : Automation {

		public System.String propertyName;
		public UnityEngine.Vector4 vec;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalVector(propertyName,vec);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Vector (ID)" )]
	class ShaderSetGlobalVector7 : Automation {

		public System.Int32 nameID;
		public UnityEngine.Vector4 vec;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalVector(nameID,vec);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Float" )]
	class ShaderSetGlobalFloat8 : Automation {

		public System.String propertyName;
		public System.Single value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalFloat(propertyName,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Float (ID)" )]
	class ShaderSetGlobalFloat9 : Automation {

		public System.Int32 nameID;
		public System.Single value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalFloat(nameID,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Int" )]
	class ShaderSetGlobalInt10 : Automation {

		public System.String propertyName;
		public System.Int32 value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalInt(propertyName,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Int (ID)" )]
	class ShaderSetGlobalInt11 : Automation {

		public System.Int32 nameID;
		public System.Int32 value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalInt(nameID,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Texture" )]
	class ShaderSetGlobalTexture12 : Automation {

		public System.String propertyName;
		public UnityEngine.Texture tex;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalTexture(propertyName,tex);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Texture (ID)" )]
	class ShaderSetGlobalTexture13 : Automation {

		public System.Int32 nameID;
		public UnityEngine.Texture tex;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalTexture(nameID,tex);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Matrix" )]
	class ShaderSetGlobalMatrix14 : Automation {

		public System.String propertyName;
		public UnityEngine.Matrix4x4 mat;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalMatrix(propertyName,mat);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Matrix (ID)" )]
	class ShaderSetGlobalMatrix15 : Automation {

		public System.Int32 nameID;
		public UnityEngine.Matrix4x4 mat;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalMatrix(nameID,mat);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Buffer" )]
	class ShaderSetGlobalBuffer16 : Automation {

		public System.String propertyName;
		public UnityEngine.ComputeBuffer buffer;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalBuffer(propertyName,buffer);
			yield break;
		}

	}

	[Automation( "Shader/Property To ID" )]
	class ShaderPropertyToID17 : Automation {

		public System.String name;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.PropertyToID(name);
			yield break;
		}

	}

	[Automation( "Shader/Warmup All Shaders" )]
	class ShaderWarmupAllShaders18 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Shader.WarmupAllShaders();
			yield break;
		}

	}


#pragma warning restore 0649
}
