using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Shader Util/Get Hardware Supports Rect Render Texture" )]
	class ShaderUtilhardwareSupportsRectRenderTextureGet0 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.hardwareSupportsRectRenderTexture;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Shader Util/Get Property Count" )]
	class ShaderUtilGetPropertyCount0 : Automation {

		public UnityEngine.Shader s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyCount(s);
			yield break;
		}

	}

	[Automation( "Shader Util/Get Property Description" )]
	class ShaderUtilGetPropertyDescription1 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyDescription(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Get Property Name" )]
	class ShaderUtilGetPropertyName2 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyName(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Get Property Type" )]
	class ShaderUtilGetPropertyType3 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ShaderUtil.ShaderPropertyType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetPropertyType(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Get Range Limits" )]
	class ShaderUtilGetRangeLimits4 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		public System.Int32 defminmax;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetRangeLimits(s,propertyIdx,defminmax);
			yield break;
		}

	}

	[Automation( "Shader Util/Get Tex Dim" )]
	class ShaderUtilGetTexDim5 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.TextureDimension Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetTexDim(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Is Shader Property Hidden" )]
	class ShaderUtilIsShaderPropertyHidden6 : ConditionalAutomation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.IsShaderPropertyHidden(s,propertyIdx);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Shader Util/Create Shader Asset" )]
	class ShaderUtilCreateShaderAsset7 : Automation {

		public System.String source;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Shader Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.CreateShaderAsset(source);
			yield break;
		}

	}

	[Automation( "Shader Util/Update Shader Asset" )]
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
