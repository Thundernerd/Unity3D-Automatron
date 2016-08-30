using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Shader Util/Get Property Count" )]
	class ShaderUtilGetPropertyCount0 : Automation {

		public UnityEngine.Shader s;
		[ReadOnly]
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
		public UnityEditor.ShaderUtil.ShaderPropertyTexDim Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.GetTexDim(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Is Shader Property Hidden" )]
	class ShaderUtilIsShaderPropertyHidden6 : Automation {

		public UnityEngine.Shader s;
		public System.Int32 propertyIdx;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ShaderUtil.IsShaderPropertyHidden(s,propertyIdx);
			yield break;
		}

	}

	[Automation( "Shader Util/Create Shader Asset" )]
	class ShaderUtilCreateShaderAsset7 : Automation {

		public System.String source;
		[ReadOnly]
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
