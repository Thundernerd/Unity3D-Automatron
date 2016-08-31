using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Editor User Build Settings/Get Selected Build Target Group" )]
	class EditorUserBuildSettingsselectedBuildTargetGroupGet0 : Automation {

		[ReadOnly]
		public UnityEditor.BuildTargetGroup Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Selected Build Target Group" )]
	class EditorUserBuildSettingsselectedBuildTargetGroupSet0 : Automation {

		public UnityEditor.BuildTargetGroup Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Selected Standalone Target" )]
	class EditorUserBuildSettingsselectedStandaloneTargetGet1 : Automation {

		[ReadOnly]
		public UnityEditor.BuildTarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Selected Standalone Target" )]
	class EditorUserBuildSettingsselectedStandaloneTargetSet1 : Automation {

		public UnityEditor.BuildTarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Psm Build Subtarget" )]
	class EditorUserBuildSettingspsmBuildSubtargetGet2 : Automation {

		[ReadOnly]
		public UnityEditor.PSMBuildSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.psmBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Psm Build Subtarget" )]
	class EditorUserBuildSettingspsmBuildSubtargetSet2 : Automation {

		public UnityEditor.PSMBuildSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.psmBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Psp 2 Build Subtarget" )]
	class EditorUserBuildSettingspsp2BuildSubtargetGet3 : Automation {

		[ReadOnly]
		public UnityEditor.PSP2BuildSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.psp2BuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Psp 2 Build Subtarget" )]
	class EditorUserBuildSettingspsp2BuildSubtargetSet3 : Automation {

		public UnityEditor.PSP2BuildSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.psp2BuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Ps 4 Build Subtarget" )]
	class EditorUserBuildSettingsps4BuildSubtargetGet4 : Automation {

		[ReadOnly]
		public UnityEditor.PS4BuildSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Ps 4 Build Subtarget" )]
	class EditorUserBuildSettingsps4BuildSubtargetSet4 : Automation {

		public UnityEditor.PS4BuildSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Sce Build Subtarget" )]
	class EditorUserBuildSettingssceBuildSubtargetGet5 : Automation {

		[ReadOnly]
		public UnityEditor.SCEBuildSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.sceBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Sce Build Subtarget" )]
	class EditorUserBuildSettingssceBuildSubtargetSet5 : Automation {

		public UnityEditor.SCEBuildSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.sceBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Explicit Null Checks" )]
	class EditorUserBuildSettingsexplicitNullChecksGet6 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.explicitNullChecks;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Explicit Null Checks" )]
	class EditorUserBuildSettingsexplicitNullChecksSet6 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.explicitNullChecks = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Need Submission Materials" )]
	class EditorUserBuildSettingsneedSubmissionMaterialsGet7 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.needSubmissionMaterials;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Need Submission Materials" )]
	class EditorUserBuildSettingsneedSubmissionMaterialsSet7 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.needSubmissionMaterials = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Compress With Ps Arc" )]
	class EditorUserBuildSettingscompressWithPsArcGet8 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.compressWithPsArc;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Compress With Ps Arc" )]
	class EditorUserBuildSettingscompressWithPsArcSet8 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.compressWithPsArc = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Force Installation" )]
	class EditorUserBuildSettingsforceInstallationGet9 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.forceInstallation;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Force Installation" )]
	class EditorUserBuildSettingsforceInstallationSet9 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.forceInstallation = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Enable Headless Mode" )]
	class EditorUserBuildSettingsenableHeadlessModeGet10 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.enableHeadlessMode;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Enable Headless Mode" )]
	class EditorUserBuildSettingsenableHeadlessModeSet10 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.enableHeadlessMode = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Build Scripts Only" )]
	class EditorUserBuildSettingsbuildScriptsOnlyGet11 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.buildScriptsOnly;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Build Scripts Only" )]
	class EditorUserBuildSettingsbuildScriptsOnlySet11 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.buildScriptsOnly = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox Build Subtarget" )]
	class EditorUserBuildSettingsxboxBuildSubtargetGet12 : Automation {

		[ReadOnly]
		public UnityEditor.XboxBuildSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox Build Subtarget" )]
	class EditorUserBuildSettingsxboxBuildSubtargetSet12 : Automation {

		public UnityEditor.XboxBuildSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wii U Build Debug Level" )]
	class EditorUserBuildSettingswiiUBuildDebugLevelGet13 : Automation {

		[ReadOnly]
		public UnityEditor.WiiUBuildDebugLevel Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wiiUBuildDebugLevel;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wii U Build Debug Level" )]
	class EditorUserBuildSettingswiiUBuildDebugLevelSet13 : Automation {

		public UnityEditor.WiiUBuildDebugLevel Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wiiUBuildDebugLevel = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wiiu Build Output" )]
	class EditorUserBuildSettingswiiuBuildOutputGet14 : Automation {

		[ReadOnly]
		public UnityEditor.WiiUBuildOutput Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wiiuBuildOutput;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wiiu Build Output" )]
	class EditorUserBuildSettingswiiuBuildOutputSet14 : Automation {

		public UnityEditor.WiiUBuildOutput Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wiiuBuildOutput = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wii U Enable Net API" )]
	class EditorUserBuildSettingswiiUEnableNetAPIGet15 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wiiUEnableNetAPI;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wii U Enable Net API" )]
	class EditorUserBuildSettingswiiUEnableNetAPISet15 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wiiUEnableNetAPI = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wii U Boot Mode" )]
	class EditorUserBuildSettingswiiUBootModeGet16 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wiiUBootMode;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wii U Boot Mode" )]
	class EditorUserBuildSettingswiiUBootModeSet16 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wiiUBootMode = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox Run Method" )]
	class EditorUserBuildSettingsxboxRunMethodGet17 : Automation {

		[ReadOnly]
		public UnityEditor.XboxRunMethod Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxRunMethod;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox Run Method" )]
	class EditorUserBuildSettingsxboxRunMethodSet17 : Automation {

		public UnityEditor.XboxRunMethod Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxRunMethod = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Streaming Install Launch Range" )]
	class EditorUserBuildSettingsstreamingInstallLaunchRangeGet18 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.streamingInstallLaunchRange;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Streaming Install Launch Range" )]
	class EditorUserBuildSettingsstreamingInstallLaunchRangeSet18 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.streamingInstallLaunchRange = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox One Deploy Method" )]
	class EditorUserBuildSettingsxboxOneDeployMethodGet19 : Automation {

		[ReadOnly]
		public UnityEditor.XboxOneDeployMethod Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxOneDeployMethod;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox One Deploy Method" )]
	class EditorUserBuildSettingsxboxOneDeployMethodSet19 : Automation {

		public UnityEditor.XboxOneDeployMethod Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxOneDeployMethod = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox One Username" )]
	class EditorUserBuildSettingsxboxOneUsernameGet20 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxOneUsername;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox One Username" )]
	class EditorUserBuildSettingsxboxOneUsernameSet20 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxOneUsername = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox One Network Share Path" )]
	class EditorUserBuildSettingsxboxOneNetworkSharePathGet21 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxOneNetworkSharePath;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox One Network Share Path" )]
	class EditorUserBuildSettingsxboxOneNetworkSharePathSet21 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxOneNetworkSharePath = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Xbox One Additional Debug Ports" )]
	class EditorUserBuildSettingsxboxOneAdditionalDebugPortsGet22 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.xboxOneAdditionalDebugPorts;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Xbox One Additional Debug Ports" )]
	class EditorUserBuildSettingsxboxOneAdditionalDebugPortsSet22 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.xboxOneAdditionalDebugPorts = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Android Build Subtarget" )]
	class EditorUserBuildSettingsandroidBuildSubtargetGet23 : Automation {

		[ReadOnly]
		public UnityEditor.MobileTextureSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.androidBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Android Build Subtarget" )]
	class EditorUserBuildSettingsandroidBuildSubtargetSet23 : Automation {

		public UnityEditor.MobileTextureSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.androidBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wsa SDK" )]
	class EditorUserBuildSettingswsaSDKGet24 : Automation {

		[ReadOnly]
		public UnityEditor.WSASDK Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wsaSDK;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wsa SDK" )]
	class EditorUserBuildSettingswsaSDKSet24 : Automation {

		public UnityEditor.WSASDK Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wsaSDK = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wsa UWP Build Type" )]
	class EditorUserBuildSettingswsaUWPBuildTypeGet25 : Automation {

		[ReadOnly]
		public UnityEditor.WSAUWPBuildType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wsaUWPBuildType;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wsa UWP Build Type" )]
	class EditorUserBuildSettingswsaUWPBuildTypeSet25 : Automation {

		public UnityEditor.WSAUWPBuildType Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wsaUWPBuildType = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wsa Build And Run Deploy Target" )]
	class EditorUserBuildSettingswsaBuildAndRunDeployTargetGet26 : Automation {

		[ReadOnly]
		public UnityEditor.WSABuildAndRunDeployTarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wsa Build And Run Deploy Target" )]
	class EditorUserBuildSettingswsaBuildAndRunDeployTargetSet26 : Automation {

		public UnityEditor.WSABuildAndRunDeployTarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Wsa Generate Reference Projects" )]
	class EditorUserBuildSettingswsaGenerateReferenceProjectsGet27 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.wsaGenerateReferenceProjects;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Wsa Generate Reference Projects" )]
	class EditorUserBuildSettingswsaGenerateReferenceProjectsSet27 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.wsaGenerateReferenceProjects = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Blackberry Build Subtarget" )]
	class EditorUserBuildSettingsblackberryBuildSubtargetGet28 : Automation {

		[ReadOnly]
		public UnityEditor.MobileTextureSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.blackberryBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Blackberry Build Subtarget" )]
	class EditorUserBuildSettingsblackberryBuildSubtargetSet28 : Automation {

		public UnityEditor.MobileTextureSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.blackberryBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Blackberry Build Type" )]
	class EditorUserBuildSettingsblackberryBuildTypeGet29 : Automation {

		[ReadOnly]
		public UnityEditor.BlackBerryBuildType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.blackberryBuildType;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Blackberry Build Type" )]
	class EditorUserBuildSettingsblackberryBuildTypeSet29 : Automation {

		public UnityEditor.BlackBerryBuildType Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.blackberryBuildType = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Tizen Build Subtarget" )]
	class EditorUserBuildSettingstizenBuildSubtargetGet30 : Automation {

		[ReadOnly]
		public UnityEditor.MobileTextureSubtarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.tizenBuildSubtarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Tizen Build Subtarget" )]
	class EditorUserBuildSettingstizenBuildSubtargetSet30 : Automation {

		public UnityEditor.MobileTextureSubtarget Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.tizenBuildSubtarget = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Web Player Streamed" )]
	class EditorUserBuildSettingswebPlayerStreamedGet31 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.webPlayerStreamed;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Web Player Streamed" )]
	class EditorUserBuildSettingswebPlayerStreamedSet31 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.webPlayerStreamed = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Web Player Offline Deployment" )]
	class EditorUserBuildSettingswebPlayerOfflineDeploymentGet32 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.webPlayerOfflineDeployment;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Web Player Offline Deployment" )]
	class EditorUserBuildSettingswebPlayerOfflineDeploymentSet32 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.webPlayerOfflineDeployment = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Active Build Target" )]
	class EditorUserBuildSettingsactiveBuildTargetGet33 : Automation {

		[ReadOnly]
		public UnityEditor.BuildTarget Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.activeBuildTarget;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Active Script Compilation Defines" )]
	class EditorUserBuildSettingsactiveScriptCompilationDefinesGet34 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.activeScriptCompilationDefines;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Development" )]
	class EditorUserBuildSettingsdevelopmentGet35 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.development;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Development" )]
	class EditorUserBuildSettingsdevelopmentSet35 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.development = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Web GL Optimization Level" )]
	class EditorUserBuildSettingswebGLOptimizationLevelGet36 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.webGLOptimizationLevel;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Web GL Optimization Level" )]
	class EditorUserBuildSettingswebGLOptimizationLevelSet36 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.webGLOptimizationLevel = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Connect Profiler" )]
	class EditorUserBuildSettingsconnectProfilerGet37 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.connectProfiler;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Connect Profiler" )]
	class EditorUserBuildSettingsconnectProfilerSet37 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.connectProfiler = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Allow Debugging" )]
	class EditorUserBuildSettingsallowDebuggingGet38 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.allowDebugging;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Allow Debugging" )]
	class EditorUserBuildSettingsallowDebuggingSet38 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.allowDebugging = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Export As Google Android Project" )]
	class EditorUserBuildSettingsexportAsGoogleAndroidProjectGet39 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Export As Google Android Project" )]
	class EditorUserBuildSettingsexportAsGoogleAndroidProjectSet39 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Symlink Libraries" )]
	class EditorUserBuildSettingssymlinkLibrariesGet40 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.symlinkLibraries;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Symlink Libraries" )]
	class EditorUserBuildSettingssymlinkLibrariesSet40 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.symlinkLibraries = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get N 3ds Create CIA File" )]
	class EditorUserBuildSettingsn3dsCreateCIAFileGet41 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.n3dsCreateCIAFile;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set N 3ds Create CIA File" )]
	class EditorUserBuildSettingsn3dsCreateCIAFileSet41 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.n3dsCreateCIAFile = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Install In Build Folder" )]
	class EditorUserBuildSettingsinstallInBuildFolderGet42 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.installInBuildFolder;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Install In Build Folder" )]
	class EditorUserBuildSettingsinstallInBuildFolderSet42 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.installInBuildFolder = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Force Optimize Script Compilation" )]
	class EditorUserBuildSettingsforceOptimizeScriptCompilationGet43 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.forceOptimizeScriptCompilation;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Force Optimize Script Compilation" )]
	class EditorUserBuildSettingsforceOptimizeScriptCompilationSet43 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.forceOptimizeScriptCompilation = Value;
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set WSA Dot Net Native" )]
	class EditorUserBuildSettingsSetWSADotNetNative0 : Automation {

		public UnityEditor.WSABuildType config;
		public System.Boolean enabled;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.SetWSADotNetNative(config,enabled);
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get WSA Dot Net Native" )]
	class EditorUserBuildSettingsGetWSADotNetNative1 : Automation {

		public UnityEditor.WSABuildType config;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.GetWSADotNetNative(config);
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Switch Active Build Target" )]
	class EditorUserBuildSettingsSwitchActiveBuildTarget2 : Automation {

		public UnityEditor.BuildTarget target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTarget(target);
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Get Build Location" )]
	class EditorUserBuildSettingsGetBuildLocation3 : Automation {

		public UnityEditor.BuildTarget target;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserBuildSettings.GetBuildLocation(target);
			yield break;
		}

	}

	[Automation( "Editor User Build Settings/Set Build Location" )]
	class EditorUserBuildSettingsSetBuildLocation4 : Automation {

		public UnityEditor.BuildTarget target;
		public System.String location;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserBuildSettings.SetBuildLocation(target,location);
			yield break;
		}

	}


#pragma warning restore 0649
}
