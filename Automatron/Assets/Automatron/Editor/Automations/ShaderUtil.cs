using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Generated/Shader Util/Get Hardware Supports Rect Render Texture" )]
	class ShaderUtilhardwareSupportsRectRenderTextureGet0 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.hardwareSupportsRectRenderTexture;
			yield break;
		}

	}
	[Automation( "Shader/Utilities/Get Property Count" )]
	class ShaderUtilGetPropertyCount0 : Automation {

		public UnityEngine.Shader s;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyCount(s);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Get Property Description" )]
	class ShaderUtilGetPropertyDescription1 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyDescription(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Get Property Name" )]
	class ShaderUtilGetPropertyName2 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyName(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Get Property Type" )]
	class ShaderUtilGetPropertyType3 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public UnityEditor.ShaderUtil.ShaderPropertyType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyType(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Get Range Limits" )]
	class ShaderUtilGetRangeLimits4 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		public System.Int32 defminmax;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetRangeLimits(s,propertyIdx,defminmax);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Get Tex Dim" )]
	class ShaderUtilGetTexDim5 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public UnityEditor.ShaderUtil.ShaderPropertyTexDim Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetTexDim(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Generated/Shader Util/Is Shader Property Hidden" )]
	class ShaderUtilIsShaderPropertyHidden6 : ConditionalAutomation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.ShaderUtil.IsShaderPropertyHidden(s,propertyIdx);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Shader/Utilities/Create Shader Asset" )]
	class ShaderUtilCreateShaderAsset7 : Automation {

		public System.String source;
		[ReadOnly]
		public UnityEngine.Shader Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.CreateShaderAsset(source);
			yield break;
		}

	}

	[Automation( "Shader/Utilities/Update Shader Asset" )]
	class ShaderUtilUpdateShaderAsset8 : Automation {

		public UnityEngine.Shader shader;
		public System.String source;

		public override IEnumerator Execute() {
			UnityEditor.ShaderUtil.UpdateShaderAsset(shader,source);
			yield break;
		}

	}


#pragma warning restore 0649
}
