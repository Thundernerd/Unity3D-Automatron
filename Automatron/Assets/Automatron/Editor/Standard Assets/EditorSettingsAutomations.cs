using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Settings/Get Unity Remote Device" )]
	class EditorSettingsunityRemoteDeviceGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.unityRemoteDevice;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Unity Remote Device" )]
	class EditorSettingsunityRemoteDeviceSet0 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.unityRemoteDevice = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Unity Remote Compression" )]
	class EditorSettingsunityRemoteCompressionGet1 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.unityRemoteCompression;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Unity Remote Compression" )]
	class EditorSettingsunityRemoteCompressionSet1 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.unityRemoteCompression = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Unity Remote Resolution" )]
	class EditorSettingsunityRemoteResolutionGet2 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.unityRemoteResolution;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Unity Remote Resolution" )]
	class EditorSettingsunityRemoteResolutionSet2 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.unityRemoteResolution = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get External Version Control" )]
	class EditorSettingsexternalVersionControlGet3 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.externalVersionControl;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set External Version Control" )]
	class EditorSettingsexternalVersionControlSet3 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.externalVersionControl = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Serialization Mode" )]
	class EditorSettingsserializationModeGet4 : Automation {

		[ReadOnly]
		public UnityEditor.SerializationMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.serializationMode;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Serialization Mode" )]
	class EditorSettingsserializationModeSet4 : Automation {

		public UnityEditor.SerializationMode Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.serializationMode = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Web Security Emulation Enabled" )]
	class EditorSettingswebSecurityEmulationEnabledGet5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.EditorSettings.webSecurityEmulationEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Settings/Set Web Security Emulation Enabled" )]
	class EditorSettingswebSecurityEmulationEnabledSet5 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.webSecurityEmulationEnabled = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Web Security Emulation Host Url" )]
	class EditorSettingswebSecurityEmulationHostUrlGet6 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.webSecurityEmulationHostUrl;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Web Security Emulation Host Url" )]
	class EditorSettingswebSecurityEmulationHostUrlSet6 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.webSecurityEmulationHostUrl = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Default Behavior Mode" )]
	class EditorSettingsdefaultBehaviorModeGet7 : Automation {

		[ReadOnly]
		public UnityEditor.EditorBehaviorMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.defaultBehaviorMode;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Default Behavior Mode" )]
	class EditorSettingsdefaultBehaviorModeSet7 : Automation {

		public UnityEditor.EditorBehaviorMode Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.defaultBehaviorMode = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Sprite Packer Mode" )]
	class EditorSettingsspritePackerModeGet8 : Automation {

		[ReadOnly]
		public UnityEditor.SpritePackerMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.spritePackerMode;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Sprite Packer Mode" )]
	class EditorSettingsspritePackerModeSet8 : Automation {

		public UnityEditor.SpritePackerMode Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.spritePackerMode = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Sprite Packer Padding Power" )]
	class EditorSettingsspritePackerPaddingPowerGet9 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.spritePackerPaddingPower;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Sprite Packer Padding Power" )]
	class EditorSettingsspritePackerPaddingPowerSet9 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.spritePackerPaddingPower = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Project Generation User Extensions" )]
	class EditorSettingsprojectGenerationUserExtensionsGet10 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.projectGenerationUserExtensions;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Project Generation User Extensions" )]
	class EditorSettingsprojectGenerationUserExtensionsSet10 : Automation {

		public System.String[] Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.projectGenerationUserExtensions = Value;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Project Generation Builtin Extensions" )]
	class EditorSettingsprojectGenerationBuiltinExtensionsGet11 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.projectGenerationBuiltinExtensions;
			yield break;
		}

	}

	[Automation( "Editor Settings/Get Project Generation Root Namespace" )]
	class EditorSettingsprojectGenerationRootNamespaceGet12 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorSettings.projectGenerationRootNamespace;
			yield break;
		}

	}

	[Automation( "Editor Settings/Set Project Generation Root Namespace" )]
	class EditorSettingsprojectGenerationRootNamespaceSet12 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorSettings.projectGenerationRootNamespace = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
