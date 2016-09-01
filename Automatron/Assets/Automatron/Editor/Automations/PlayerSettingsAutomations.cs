using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Player Settings/Get Company Name" )]
	class PlayerSettingscompanyNameGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.companyName;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Company Name" )]
	class PlayerSettingscompanyNameSet0 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.companyName = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Product Name" )]
	class PlayerSettingsproductNameGet1 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.productName;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Product Name" )]
	class PlayerSettingsproductNameSet1 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.productName = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Show Unity Splash Screen" )]
	class PlayerSettingsshowUnitySplashScreenGet2 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.showUnitySplashScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Show Unity Splash Screen" )]
	class PlayerSettingsshowUnitySplashScreenSet2 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.showUnitySplashScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Cloud Project Id" )]
	class PlayerSettingscloudProjectIdGet3 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.cloudProjectId;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Product GUID" )]
	class PlayerSettingsproductGUIDGet4 : Automation {

		[ReadOnly]
		public System.Guid Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.productGUID;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Color Space" )]
	class PlayerSettingscolorSpaceGet5 : Automation {

		[ReadOnly]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.colorSpace;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Color Space" )]
	class PlayerSettingscolorSpaceSet5 : Automation {

		public UnityEngine.ColorSpace Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.colorSpace = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Screen Width" )]
	class PlayerSettingsdefaultScreenWidthGet6 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultScreenWidth;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Screen Width" )]
	class PlayerSettingsdefaultScreenWidthSet6 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultScreenWidth = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Screen Height" )]
	class PlayerSettingsdefaultScreenHeightGet7 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultScreenHeight;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Screen Height" )]
	class PlayerSettingsdefaultScreenHeightSet7 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultScreenHeight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Web Screen Width" )]
	class PlayerSettingsdefaultWebScreenWidthGet8 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultWebScreenWidth;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Web Screen Width" )]
	class PlayerSettingsdefaultWebScreenWidthSet8 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultWebScreenWidth = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Web Screen Height" )]
	class PlayerSettingsdefaultWebScreenHeightGet9 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultWebScreenHeight;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Web Screen Height" )]
	class PlayerSettingsdefaultWebScreenHeightSet9 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultWebScreenHeight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Display Resolution Dialog" )]
	class PlayerSettingsdisplayResolutionDialogGet10 : Automation {

		[ReadOnly]
		public UnityEditor.ResolutionDialogSetting Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.displayResolutionDialog;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Display Resolution Dialog" )]
	class PlayerSettingsdisplayResolutionDialogSet10 : Automation {

		public UnityEditor.ResolutionDialogSetting Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.displayResolutionDialog = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Is Full Screen" )]
	class PlayerSettingsdefaultIsFullScreenGet11 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.defaultIsFullScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Default Is Full Screen" )]
	class PlayerSettingsdefaultIsFullScreenSet11 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultIsFullScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Is Native Resolution" )]
	class PlayerSettingsdefaultIsNativeResolutionGet12 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.defaultIsNativeResolution;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Default Is Native Resolution" )]
	class PlayerSettingsdefaultIsNativeResolutionSet12 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultIsNativeResolution = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Run In Background" )]
	class PlayerSettingsrunInBackgroundGet13 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.runInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Run In Background" )]
	class PlayerSettingsrunInBackgroundSet13 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.runInBackground = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Capture Single Screen" )]
	class PlayerSettingscaptureSingleScreenGet14 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.captureSingleScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Capture Single Screen" )]
	class PlayerSettingscaptureSingleScreenSet14 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.captureSingleScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Player Log" )]
	class PlayerSettingsusePlayerLogGet15 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.usePlayerLog;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Player Log" )]
	class PlayerSettingsusePlayerLogSet15 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.usePlayerLog = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Resizable Window" )]
	class PlayerSettingsresizableWindowGet16 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.resizableWindow;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Resizable Window" )]
	class PlayerSettingsresizableWindowSet16 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.resizableWindow = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bake Collision Meshes" )]
	class PlayerSettingsbakeCollisionMeshesGet17 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.bakeCollisionMeshes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Bake Collision Meshes" )]
	class PlayerSettingsbakeCollisionMeshesSet17 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bakeCollisionMeshes = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Mac App Store Validation" )]
	class PlayerSettingsuseMacAppStoreValidationGet18 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.useMacAppStoreValidation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Mac App Store Validation" )]
	class PlayerSettingsuseMacAppStoreValidationSet18 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.useMacAppStoreValidation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mac Fullscreen Mode" )]
	class PlayerSettingsmacFullscreenModeGet19 : Automation {

		[ReadOnly]
		public UnityEditor.MacFullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.macFullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Mac Fullscreen Mode" )]
	class PlayerSettingsmacFullscreenModeSet19 : Automation {

		public UnityEditor.MacFullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.macFullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get D 3d 9 Fullscreen Mode" )]
	class PlayerSettingsd3d9FullscreenModeGet20 : Automation {

		[ReadOnly]
		public UnityEditor.D3D9FullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.d3d9FullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set D 3d 9 Fullscreen Mode" )]
	class PlayerSettingsd3d9FullscreenModeSet20 : Automation {

		public UnityEditor.D3D9FullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.d3d9FullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get D 3d 11 Fullscreen Mode" )]
	class PlayerSettingsd3d11FullscreenModeGet21 : Automation {

		[ReadOnly]
		public UnityEditor.D3D11FullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.d3d11FullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set D 3d 11 Fullscreen Mode" )]
	class PlayerSettingsd3d11FullscreenModeSet21 : Automation {

		public UnityEditor.D3D11FullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.d3d11FullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Virtual Reality Supported" )]
	class PlayerSettingsvirtualRealitySupportedGet22 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.virtualRealitySupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Virtual Reality Supported" )]
	class PlayerSettingsvirtualRealitySupportedSet22 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.virtualRealitySupported = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Visible In Background" )]
	class PlayerSettingsvisibleInBackgroundGet23 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.visibleInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Visible In Background" )]
	class PlayerSettingsvisibleInBackgroundSet23 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.visibleInBackground = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allow Fullscreen Switch" )]
	class PlayerSettingsallowFullscreenSwitchGet24 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.allowFullscreenSwitch;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allow Fullscreen Switch" )]
	class PlayerSettingsallowFullscreenSwitchSet24 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowFullscreenSwitch = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Force Single Instance" )]
	class PlayerSettingsforceSingleInstanceGet25 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.forceSingleInstance;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Force Single Instance" )]
	class PlayerSettingsforceSingleInstanceSet25 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.forceSingleInstance = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Resolution Dialog Banner" )]
	class PlayerSettingsresolutionDialogBannerGet26 : Automation {

		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.resolutionDialogBanner;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Resolution Dialog Banner" )]
	class PlayerSettingsresolutionDialogBannerSet26 : Automation {

		public UnityEngine.Texture2D Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.resolutionDialogBanner = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Virtual Reality Splash Screen" )]
	class PlayerSettingsvirtualRealitySplashScreenGet27 : Automation {

		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.virtualRealitySplashScreen;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Virtual Reality Splash Screen" )]
	class PlayerSettingsvirtualRealitySplashScreenSet27 : Automation {

		public UnityEngine.Texture2D Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.virtualRealitySplashScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get I Phone Bundle Identifier" )]
	class PlayerSettingsiPhoneBundleIdentifierGet28 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.iPhoneBundleIdentifier;
			yield break;
		}

	}

	[Automation( "Player Settings/Set I Phone Bundle Identifier" )]
	class PlayerSettingsiPhoneBundleIdentifierSet28 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.iPhoneBundleIdentifier = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Keystore Pass" )]
	class PlayerSettingskeystorePassGet29 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.keystorePass;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Keystore Pass" )]
	class PlayerSettingskeystorePassSet29 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.keystorePass = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Keyalias Pass" )]
	class PlayerSettingskeyaliasPassGet30 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.keyaliasPass;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Keyalias Pass" )]
	class PlayerSettingskeyaliasPassSet30 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.keyaliasPass = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Gpu Skinning" )]
	class PlayerSettingsgpuSkinningGet31 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.gpuSkinning;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Gpu Skinning" )]
	class PlayerSettingsgpuSkinningSet31 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.gpuSkinning = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Enable Internal Profiler" )]
	class PlayerSettingsenableInternalProfilerGet32 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.enableInternalProfiler;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Enable Internal Profiler" )]
	class PlayerSettingsenableInternalProfilerSet32 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.enableInternalProfiler = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Action On Dot Net Unhandled Exception" )]
	class PlayerSettingsactionOnDotNetUnhandledExceptionGet33 : Automation {

		[ReadOnly]
		public UnityEditor.ActionOnDotNetUnhandledException Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.actionOnDotNetUnhandledException;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Action On Dot Net Unhandled Exception" )]
	class PlayerSettingsactionOnDotNetUnhandledExceptionSet33 : Automation {

		public UnityEditor.ActionOnDotNetUnhandledException Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.actionOnDotNetUnhandledException = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Log Obj C Uncaught Exceptions" )]
	class PlayerSettingslogObjCUncaughtExceptionsGet34 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.logObjCUncaughtExceptions;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Log Obj C Uncaught Exceptions" )]
	class PlayerSettingslogObjCUncaughtExceptionsSet34 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.logObjCUncaughtExceptions = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Enable Crash Report API" )]
	class PlayerSettingsenableCrashReportAPIGet35 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.enableCrashReportAPI;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Enable Crash Report API" )]
	class PlayerSettingsenableCrashReportAPISet35 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.enableCrashReportAPI = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Location Usage Description" )]
	class PlayerSettingslocationUsageDescriptionGet36 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.locationUsageDescription;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Location Usage Description" )]
	class PlayerSettingslocationUsageDescriptionSet36 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.locationUsageDescription = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bundle Identifier" )]
	class PlayerSettingsbundleIdentifierGet37 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.bundleIdentifier;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Bundle Identifier" )]
	class PlayerSettingsbundleIdentifierSet37 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bundleIdentifier = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bundle Version" )]
	class PlayerSettingsbundleVersionGet38 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.bundleVersion;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Bundle Version" )]
	class PlayerSettingsbundleVersionSet38 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bundleVersion = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Status Bar Hidden" )]
	class PlayerSettingsstatusBarHiddenGet39 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.statusBarHidden;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Status Bar Hidden" )]
	class PlayerSettingsstatusBarHiddenSet39 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.statusBarHidden = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Stripping Level" )]
	class PlayerSettingsstrippingLevelGet40 : Automation {

		[ReadOnly]
		public UnityEditor.StrippingLevel Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.strippingLevel;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Stripping Level" )]
	class PlayerSettingsstrippingLevelSet40 : Automation {

		public UnityEditor.StrippingLevel Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.strippingLevel = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Strip Engine Code" )]
	class PlayerSettingsstripEngineCodeGet41 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.stripEngineCode;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Strip Engine Code" )]
	class PlayerSettingsstripEngineCodeSet41 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.stripEngineCode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Interface Orientation" )]
	class PlayerSettingsdefaultInterfaceOrientationGet42 : Automation {

		[ReadOnly]
		public UnityEditor.UIOrientation Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultInterfaceOrientation;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Interface Orientation" )]
	class PlayerSettingsdefaultInterfaceOrientationSet42 : Automation {

		public UnityEditor.UIOrientation Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultInterfaceOrientation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Portrait" )]
	class PlayerSettingsallowedAutorotateToPortraitGet43 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToPortrait;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Portrait" )]
	class PlayerSettingsallowedAutorotateToPortraitSet43 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToPortrait = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Portrait Upside Down" )]
	class PlayerSettingsallowedAutorotateToPortraitUpsideDownGet44 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Portrait Upside Down" )]
	class PlayerSettingsallowedAutorotateToPortraitUpsideDownSet44 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Landscape Right" )]
	class PlayerSettingsallowedAutorotateToLandscapeRightGet45 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Landscape Right" )]
	class PlayerSettingsallowedAutorotateToLandscapeRightSet45 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Landscape Left" )]
	class PlayerSettingsallowedAutorotateToLandscapeLeftGet46 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Landscape Left" )]
	class PlayerSettingsallowedAutorotateToLandscapeLeftSet46 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Animated Autorotation" )]
	class PlayerSettingsuseAnimatedAutorotationGet47 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.useAnimatedAutorotation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Animated Autorotation" )]
	class PlayerSettingsuseAnimatedAutorotationSet47 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.useAnimatedAutorotation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use 32 Bit Display Buffer" )]
	class PlayerSettingsuse32BitDisplayBufferGet48 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.use32BitDisplayBuffer;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use 32 Bit Display Buffer" )]
	class PlayerSettingsuse32BitDisplayBufferSet48 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.use32BitDisplayBuffer = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Api Compatibility Level" )]
	class PlayerSettingsapiCompatibilityLevelGet49 : Automation {

		[ReadOnly]
		public UnityEditor.ApiCompatibilityLevel Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.apiCompatibilityLevel;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Api Compatibility Level" )]
	class PlayerSettingsapiCompatibilityLevelSet49 : Automation {

		public UnityEditor.ApiCompatibilityLevel Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.apiCompatibilityLevel = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Strip Unused Mesh Components" )]
	class PlayerSettingsstripUnusedMeshComponentsGet50 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.stripUnusedMeshComponents;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Strip Unused Mesh Components" )]
	class PlayerSettingsstripUnusedMeshComponentsSet50 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.stripUnusedMeshComponents = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Advanced License" )]
	class PlayerSettingsadvancedLicenseGet51 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.advancedLicense;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Aot Options" )]
	class PlayerSettingsaotOptionsGet52 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.aotOptions;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Aot Options" )]
	class PlayerSettingsaotOptionsSet52 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.aotOptions = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Accelerometer Frequency" )]
	class PlayerSettingsaccelerometerFrequencyGet53 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.accelerometerFrequency;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Accelerometer Frequency" )]
	class PlayerSettingsaccelerometerFrequencySet53 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.accelerometerFrequency = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get MT Rendering" )]
	class PlayerSettingsMTRenderingGet54 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.MTRendering;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set MT Rendering" )]
	class PlayerSettingsMTRenderingSet54 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.MTRendering = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mobile MT Rendering" )]
	class PlayerSettingsmobileMTRenderingGet55 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.mobileMTRendering;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Mobile MT Rendering" )]
	class PlayerSettingsmobileMTRenderingSet55 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.mobileMTRendering = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Rendering Path" )]
	class PlayerSettingsrenderingPathGet56 : Automation {

		[ReadOnly]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.renderingPath;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Rendering Path" )]
	class PlayerSettingsrenderingPathSet56 : Automation {

		public UnityEngine.RenderingPath Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.renderingPath = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mobile Rendering Path" )]
	class PlayerSettingsmobileRenderingPathGet57 : Automation {

		[ReadOnly]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.mobileRenderingPath;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Mobile Rendering Path" )]
	class PlayerSettingsmobileRenderingPathSet57 : Automation {

		public UnityEngine.RenderingPath Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.mobileRenderingPath = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Stereoscopic 3D" )]
	class PlayerSettingsstereoscopic3DGet58 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.stereoscopic3D;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Stereoscopic 3D" )]
	class PlayerSettingsstereoscopic3DSet58 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.stereoscopic3D = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Property Int" )]
	class PlayerSettingsSetPropertyInt0 : Automation {

		public System.String name;
		public System.Int32 value;
		public UnityEditor.BuildTargetGroup target;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetPropertyInt(name,value,target);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Property Int" )]
	class PlayerSettingsGetPropertyInt1 : Automation {

		public System.String name;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetPropertyInt(name,target);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Property Optional Int" )]
	class PlayerSettingsGetPropertyOptionalInt2 : ConditionalAutomation {

		public System.String name;
		public System.Int32 value;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.GetPropertyOptionalInt(name,ref value,target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Property Bool" )]
	class PlayerSettingsSetPropertyBool3 : Automation {

		public System.String name;
		public System.Boolean value;
		public UnityEditor.BuildTargetGroup target;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetPropertyBool(name,value,target);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Property Bool" )]
	class PlayerSettingsGetPropertyBool4 : ConditionalAutomation {

		public System.String name;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.GetPropertyBool(name,target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Property Optional Bool" )]
	class PlayerSettingsGetPropertyOptionalBool5 : ConditionalAutomation {

		public System.String name;
		public System.Boolean value;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.GetPropertyOptionalBool(name,ref value,target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Property String" )]
	class PlayerSettingsSetPropertyString6 : Automation {

		public System.String name;
		public System.String value;
		public UnityEditor.BuildTargetGroup target;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetPropertyString(name,value,target);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Property String" )]
	class PlayerSettingsGetPropertyString7 : Automation {

		public System.String name;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetPropertyString(name,target);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Property Optional String" )]
	class PlayerSettingsGetPropertyOptionalString8 : ConditionalAutomation {

		public System.String name;
		public System.String value;
		public UnityEditor.BuildTargetGroup target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.GetPropertyOptionalString(name,ref value,target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Has Aspect Ratio" )]
	class PlayerSettingsHasAspectRatio9 : ConditionalAutomation {

		public UnityEditor.AspectRatio aspectRatio;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.HasAspectRatio(aspectRatio);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Aspect Ratio" )]
	class PlayerSettingsSetAspectRatio10 : Automation {

		public UnityEditor.AspectRatio aspectRatio;
		public System.Boolean enable;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetAspectRatio(aspectRatio,enable);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Icons For Target Group" )]
	class PlayerSettingsGetIconsForTargetGroup11 : Automation {

		public UnityEditor.BuildTargetGroup platform;
		[ReadOnly]
		public UnityEngine.Texture2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetIconsForTargetGroup(platform);
			yield break;
		}

	}

	[Automation( "Player Settings/Set Icons For Target Group" )]
	class PlayerSettingsSetIconsForTargetGroup12 : Automation {

		public UnityEditor.BuildTargetGroup platform;
		public UnityEngine.Texture2D[] icons;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetIconsForTargetGroup(platform,icons);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Icon Sizes For Target Group" )]
	class PlayerSettingsGetIconSizesForTargetGroup13 : Automation {

		public UnityEditor.BuildTargetGroup platform;
		[ReadOnly]
		public System.Int32[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetIconSizesForTargetGroup(platform);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Graphics AP Is" )]
	class PlayerSettingsGetGraphicsAPIs14 : Automation {

		public UnityEditor.BuildTarget platform;
		[ReadOnly]
		public UnityEngine.Rendering.GraphicsDeviceType[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetGraphicsAPIs(platform);
			yield break;
		}

	}

	[Automation( "Player Settings/Set Graphics AP Is" )]
	class PlayerSettingsSetGraphicsAPIs15 : Automation {

		public UnityEditor.BuildTarget platform;
		public UnityEngine.Rendering.GraphicsDeviceType[] apis;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetGraphicsAPIs(platform,apis);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Default Graphics AP Is" )]
	class PlayerSettingsGetUseDefaultGraphicsAPIs16 : ConditionalAutomation {

		public UnityEditor.BuildTarget platform;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.PlayerSettings.GetUseDefaultGraphicsAPIs(platform);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Default Graphics AP Is" )]
	class PlayerSettingsSetUseDefaultGraphicsAPIs17 : Automation {

		public UnityEditor.BuildTarget platform;
		public System.Boolean automatic;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetUseDefaultGraphicsAPIs(platform,automatic);
			yield break;
		}

	}

	[Automation( "Player Settings/Get Scripting Define Symbols For Group" )]
	class PlayerSettingsGetScriptingDefineSymbolsForGroup18 : Automation {

		public UnityEditor.BuildTargetGroup targetGroup;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetScriptingDefineSymbolsForGroup(targetGroup);
			yield break;
		}

	}

	[Automation( "Player Settings/Set Scripting Define Symbols For Group" )]
	class PlayerSettingsSetScriptingDefineSymbolsForGroup19 : Automation {

		public UnityEditor.BuildTargetGroup targetGroup;
		public System.String defines;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup,defines);
			yield break;
		}

	}


#pragma warning restore 0649
}
