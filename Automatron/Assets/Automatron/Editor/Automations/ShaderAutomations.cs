using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Shader/Get Is Supported" )]
	class ShaderisSupportedGet0 : ConditionalAutomation {

		public UnityEngine.Shader Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Shader/Get Global Shader Hardware Tier" )]
	class ShaderglobalShaderHardwareTierGet1 : Automation {

		[ReadOnly]
		public UnityEngine.Rendering.ShaderHardwareTier Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.globalShaderHardwareTier;
			yield break;
		}

	}

	[Automation( "Shader/Set Global Shader Hardware Tier" )]
	class ShaderglobalShaderHardwareTierSet1 : Automation {

		public UnityEngine.Rendering.ShaderHardwareTier Value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.globalShaderHardwareTier = Value;
			yield break;
		}

	}

	[Automation( "Shader/Get Maximum LOD" )]
	class ShadermaximumLODGet2 : Automation {

		public UnityEngine.Shader Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.maximumLOD;
			yield break;
		}

	}

	[Automation( "Shader/Set Maximum LOD" )]
	class ShadermaximumLODSet2 : Automation {

		public UnityEngine.Shader Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.maximumLOD = Value;
			yield break;
		}

	}

	[Automation( "Shader/Get Global Maximum LOD" )]
	class ShaderglobalMaximumLODGet3 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.globalMaximumLOD;
			yield break;
		}

	}

	[Automation( "Shader/Set Global Maximum LOD" )]
	class ShaderglobalMaximumLODSet3 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.globalMaximumLOD = Value;
			yield break;
		}

	}

	[Automation( "Shader/Get Render Queue" )]
	class ShaderrenderQueueGet4 : Automation {

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

	[Automation( "Shader/Is Keyword Enabled" )]
	class ShaderIsKeywordEnabled3 : ConditionalAutomation {

		public System.String keyword;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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

	[Automation( "Shader/Set Global Vector" )]
	class ShaderSetGlobalVector5 : Automation {

		public System.String propertyName;
		public UnityEngine.Vector4 vec;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalVector(propertyName,vec);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Float" )]
	class ShaderSetGlobalFloat6 : Automation {

		public System.String propertyName;
		public System.Single value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalFloat(propertyName,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Int" )]
	class ShaderSetGlobalInt7 : Automation {

		public System.String propertyName;
		public System.Int32 value;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalInt(propertyName,value);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Texture" )]
	class ShaderSetGlobalTexture8 : Automation {

		public System.String propertyName;
		public UnityEngine.Texture tex;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalTexture(propertyName,tex);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Matrix" )]
	class ShaderSetGlobalMatrix9 : Automation {

		public System.String propertyName;
		public UnityEngine.Matrix4x4 mat;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalMatrix(propertyName,mat);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Float Array" )]
	class ShaderSetGlobalFloatArray10 : Automation {

		public System.String propertyName;
		public System.Single[] values;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalFloatArray(propertyName,values);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Vector Array" )]
	class ShaderSetGlobalVectorArray11 : Automation {

		public System.String propertyName;
		public UnityEngine.Vector4[] values;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalVectorArray(propertyName,values);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Matrix Array" )]
	class ShaderSetGlobalMatrixArray12 : Automation {

		public System.String propertyName;
		public UnityEngine.Matrix4x4[] values;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalMatrixArray(propertyName,values);
			yield break;
		}

	}

	[Automation( "Shader/Set Global Buffer" )]
	class ShaderSetGlobalBuffer13 : Automation {

		public System.String propertyName;
		public UnityEngine.ComputeBuffer buffer;

		public override IEnumerator Execute() {
			UnityEngine.Shader.SetGlobalBuffer(propertyName,buffer);
			yield break;
		}

	}

	[Automation( "Shader/Property To ID" )]
	class ShaderPropertyToID14 : Automation {

		public System.String name;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Shader.PropertyToID(name);
			yield break;
		}

	}

	[Automation( "Shader/Warmup All Shaders" )]
	class ShaderWarmupAllShaders15 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Shader.WarmupAllShaders();
			yield break;
		}

	}


#pragma warning restore 0649
}
