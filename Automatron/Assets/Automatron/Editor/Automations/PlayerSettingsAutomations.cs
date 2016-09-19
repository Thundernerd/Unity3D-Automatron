#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Player Settings/Get Company Name" )]
	class PlayerSettingscompanyNameGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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

	[Automation( "Player Settings/Get Splash Screen Style" )]
	class PlayerSettingssplashScreenStyleGet3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.SplashScreenStyle Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.splashScreenStyle;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Splash Screen Style" )]
	class PlayerSettingssplashScreenStyleSet3 : Automation {

		public UnityEditor.SplashScreenStyle Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.splashScreenStyle = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Cloud Project Id" )]
	class PlayerSettingscloudProjectIdGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.cloudProjectId;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Product GUID" )]
	class PlayerSettingsproductGUIDGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Guid Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.productGUID;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Color Space" )]
	class PlayerSettingscolorSpaceGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.colorSpace;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Color Space" )]
	class PlayerSettingscolorSpaceSet6 : Automation {

		public UnityEngine.ColorSpace Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.colorSpace = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Screen Width" )]
	class PlayerSettingsdefaultScreenWidthGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultScreenWidth;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Screen Width" )]
	class PlayerSettingsdefaultScreenWidthSet7 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultScreenWidth = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Screen Height" )]
	class PlayerSettingsdefaultScreenHeightGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultScreenHeight;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Screen Height" )]
	class PlayerSettingsdefaultScreenHeightSet8 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultScreenHeight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Web Screen Width" )]
	class PlayerSettingsdefaultWebScreenWidthGet9 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultWebScreenWidth;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Web Screen Width" )]
	class PlayerSettingsdefaultWebScreenWidthSet9 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultWebScreenWidth = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Web Screen Height" )]
	class PlayerSettingsdefaultWebScreenHeightGet10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultWebScreenHeight;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Web Screen Height" )]
	class PlayerSettingsdefaultWebScreenHeightSet10 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultWebScreenHeight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Display Resolution Dialog" )]
	class PlayerSettingsdisplayResolutionDialogGet11 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ResolutionDialogSetting Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.displayResolutionDialog;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Display Resolution Dialog" )]
	class PlayerSettingsdisplayResolutionDialogSet11 : Automation {

		public UnityEditor.ResolutionDialogSetting Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.displayResolutionDialog = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Is Full Screen" )]
	class PlayerSettingsdefaultIsFullScreenGet12 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultIsFullScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Default Is Full Screen" )]
	class PlayerSettingsdefaultIsFullScreenSet12 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultIsFullScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Is Native Resolution" )]
	class PlayerSettingsdefaultIsNativeResolutionGet13 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultIsNativeResolution;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Default Is Native Resolution" )]
	class PlayerSettingsdefaultIsNativeResolutionSet13 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultIsNativeResolution = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Run In Background" )]
	class PlayerSettingsrunInBackgroundGet14 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.runInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Run In Background" )]
	class PlayerSettingsrunInBackgroundSet14 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.runInBackground = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Capture Single Screen" )]
	class PlayerSettingscaptureSingleScreenGet15 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.captureSingleScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Capture Single Screen" )]
	class PlayerSettingscaptureSingleScreenSet15 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.captureSingleScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Player Log" )]
	class PlayerSettingsusePlayerLogGet16 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.usePlayerLog;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Player Log" )]
	class PlayerSettingsusePlayerLogSet16 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.usePlayerLog = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Resizable Window" )]
	class PlayerSettingsresizableWindowGet17 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.resizableWindow;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Resizable Window" )]
	class PlayerSettingsresizableWindowSet17 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.resizableWindow = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bake Collision Meshes" )]
	class PlayerSettingsbakeCollisionMeshesGet18 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.bakeCollisionMeshes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Bake Collision Meshes" )]
	class PlayerSettingsbakeCollisionMeshesSet18 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bakeCollisionMeshes = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Mac App Store Validation" )]
	class PlayerSettingsuseMacAppStoreValidationGet19 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.useMacAppStoreValidation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Mac App Store Validation" )]
	class PlayerSettingsuseMacAppStoreValidationSet19 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.useMacAppStoreValidation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mac Fullscreen Mode" )]
	class PlayerSettingsmacFullscreenModeGet20 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.MacFullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.macFullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Mac Fullscreen Mode" )]
	class PlayerSettingsmacFullscreenModeSet20 : Automation {

		public UnityEditor.MacFullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.macFullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get D 3d 9 Fullscreen Mode" )]
	class PlayerSettingsd3d9FullscreenModeGet21 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.D3D9FullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.d3d9FullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set D 3d 9 Fullscreen Mode" )]
	class PlayerSettingsd3d9FullscreenModeSet21 : Automation {

		public UnityEditor.D3D9FullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.d3d9FullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get D 3d 11 Fullscreen Mode" )]
	class PlayerSettingsd3d11FullscreenModeGet22 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.D3D11FullscreenMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.d3d11FullscreenMode;
			yield break;
		}

	}

	[Automation( "Player Settings/Set D 3d 11 Fullscreen Mode" )]
	class PlayerSettingsd3d11FullscreenModeSet22 : Automation {

		public UnityEditor.D3D11FullscreenMode Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.d3d11FullscreenMode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Virtual Reality Supported" )]
	class PlayerSettingsvirtualRealitySupportedGet23 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.virtualRealitySupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Virtual Reality Supported" )]
	class PlayerSettingsvirtualRealitySupportedSet23 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.virtualRealitySupported = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Single Pass Stereo Rendering" )]
	class PlayerSettingssinglePassStereoRenderingGet24 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.singlePassStereoRendering;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Single Pass Stereo Rendering" )]
	class PlayerSettingssinglePassStereoRenderingSet24 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.singlePassStereoRendering = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Protect Graphics Memory" )]
	class PlayerSettingsprotectGraphicsMemoryGet25 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.protectGraphicsMemory;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Protect Graphics Memory" )]
	class PlayerSettingsprotectGraphicsMemorySet25 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.protectGraphicsMemory = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Visible In Background" )]
	class PlayerSettingsvisibleInBackgroundGet26 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.visibleInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Visible In Background" )]
	class PlayerSettingsvisibleInBackgroundSet26 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.visibleInBackground = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allow Fullscreen Switch" )]
	class PlayerSettingsallowFullscreenSwitchGet27 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.allowFullscreenSwitch;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allow Fullscreen Switch" )]
	class PlayerSettingsallowFullscreenSwitchSet27 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowFullscreenSwitch = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Force Single Instance" )]
	class PlayerSettingsforceSingleInstanceGet28 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.forceSingleInstance;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Force Single Instance" )]
	class PlayerSettingsforceSingleInstanceSet28 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.forceSingleInstance = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Resolution Dialog Banner" )]
	class PlayerSettingsresolutionDialogBannerGet29 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.resolutionDialogBanner;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Resolution Dialog Banner" )]
	class PlayerSettingsresolutionDialogBannerSet29 : Automation {

		public UnityEngine.Texture2D Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.resolutionDialogBanner = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Virtual Reality Splash Screen" )]
	class PlayerSettingsvirtualRealitySplashScreenGet30 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.virtualRealitySplashScreen;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Virtual Reality Splash Screen" )]
	class PlayerSettingsvirtualRealitySplashScreenSet30 : Automation {

		public UnityEngine.Texture2D Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.virtualRealitySplashScreen = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get I Phone Bundle Identifier" )]
	class PlayerSettingsiPhoneBundleIdentifierGet31 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.iPhoneBundleIdentifier;
			yield break;
		}

	}

	[Automation( "Player Settings/Set I Phone Bundle Identifier" )]
	class PlayerSettingsiPhoneBundleIdentifierSet31 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.iPhoneBundleIdentifier = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Keystore Pass" )]
	class PlayerSettingskeystorePassGet32 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.keystorePass;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Keystore Pass" )]
	class PlayerSettingskeystorePassSet32 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.keystorePass = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Keyalias Pass" )]
	class PlayerSettingskeyaliasPassGet33 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.keyaliasPass;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Keyalias Pass" )]
	class PlayerSettingskeyaliasPassSet33 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.keyaliasPass = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Title Id" )]
	class PlayerSettingsxboxTitleIdGet34 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxTitleId;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Xbox Title Id" )]
	class PlayerSettingsxboxTitleIdSet34 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.xboxTitleId = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Image Xex File Path" )]
	class PlayerSettingsxboxImageXexFilePathGet35 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxImageXexFilePath;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Spa File Path" )]
	class PlayerSettingsxboxSpaFilePathGet36 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxSpaFilePath;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Generate Spa" )]
	class PlayerSettingsxboxGenerateSpaGet37 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxGenerateSpa;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Enable Guest" )]
	class PlayerSettingsxboxEnableGuestGet38 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxEnableGuest;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Deploy Kinect Resources" )]
	class PlayerSettingsxboxDeployKinectResourcesGet39 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxDeployKinectResources;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Deploy Kinect Head Orientation" )]
	class PlayerSettingsxboxDeployKinectHeadOrientationGet40 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxDeployKinectHeadOrientation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Xbox Deploy Kinect Head Orientation" )]
	class PlayerSettingsxboxDeployKinectHeadOrientationSet40 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.xboxDeployKinectHeadOrientation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Deploy Kinect Head Position" )]
	class PlayerSettingsxboxDeployKinectHeadPositionGet41 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxDeployKinectHeadPosition;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Xbox Deploy Kinect Head Position" )]
	class PlayerSettingsxboxDeployKinectHeadPositionSet41 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.xboxDeployKinectHeadPosition = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Splash Screen" )]
	class PlayerSettingsxboxSplashScreenGet42 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxSplashScreen;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Additional Title Memory Size" )]
	class PlayerSettingsxboxAdditionalTitleMemorySizeGet43 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxAdditionalTitleMemorySize;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Xbox Additional Title Memory Size" )]
	class PlayerSettingsxboxAdditionalTitleMemorySizeSet43 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.xboxAdditionalTitleMemorySize = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox Enable Kinect" )]
	class PlayerSettingsxboxEnableKinectGet44 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxEnableKinect;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Enable Kinect Auto Tracking" )]
	class PlayerSettingsxboxEnableKinectAutoTrackingGet45 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxEnableKinectAutoTracking;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Enable Speech" )]
	class PlayerSettingsxboxEnableSpeechGet46 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxEnableSpeech;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Speech DB" )]
	class PlayerSettingsxboxSpeechDBGet47 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxSpeechDB;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Gpu Skinning" )]
	class PlayerSettingsgpuSkinningGet48 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.gpuSkinning;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Gpu Skinning" )]
	class PlayerSettingsgpuSkinningSet48 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.gpuSkinning = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Graphics Jobs" )]
	class PlayerSettingsgraphicsJobsGet49 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.graphicsJobs;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Graphics Jobs" )]
	class PlayerSettingsgraphicsJobsSet49 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.graphicsJobs = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Xbox PIX Texture Capture" )]
	class PlayerSettingsxboxPIXTextureCaptureGet50 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxPIXTextureCapture;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox Enable Avatar" )]
	class PlayerSettingsxboxEnableAvatarGet51 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxEnableAvatar;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Xbox One Resolution" )]
	class PlayerSettingsxboxOneResolutionGet52 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.xboxOneResolution;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Enable Internal Profiler" )]
	class PlayerSettingsenableInternalProfilerGet53 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.enableInternalProfiler;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Enable Internal Profiler" )]
	class PlayerSettingsenableInternalProfilerSet53 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.enableInternalProfiler = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Action On Dot Net Unhandled Exception" )]
	class PlayerSettingsactionOnDotNetUnhandledExceptionGet54 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ActionOnDotNetUnhandledException Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.actionOnDotNetUnhandledException;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Action On Dot Net Unhandled Exception" )]
	class PlayerSettingsactionOnDotNetUnhandledExceptionSet54 : Automation {

		public UnityEditor.ActionOnDotNetUnhandledException Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.actionOnDotNetUnhandledException = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Log Obj C Uncaught Exceptions" )]
	class PlayerSettingslogObjCUncaughtExceptionsGet55 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.logObjCUncaughtExceptions;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Log Obj C Uncaught Exceptions" )]
	class PlayerSettingslogObjCUncaughtExceptionsSet55 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.logObjCUncaughtExceptions = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Enable Crash Report API" )]
	class PlayerSettingsenableCrashReportAPIGet56 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.enableCrashReportAPI;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Enable Crash Report API" )]
	class PlayerSettingsenableCrashReportAPISet56 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.enableCrashReportAPI = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Location Usage Description" )]
	class PlayerSettingslocationUsageDescriptionGet57 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.locationUsageDescription;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Location Usage Description" )]
	class PlayerSettingslocationUsageDescriptionSet57 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.locationUsageDescription = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bundle Identifier" )]
	class PlayerSettingsbundleIdentifierGet58 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.bundleIdentifier;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Bundle Identifier" )]
	class PlayerSettingsbundleIdentifierSet58 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bundleIdentifier = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Bundle Version" )]
	class PlayerSettingsbundleVersionGet59 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.bundleVersion;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Bundle Version" )]
	class PlayerSettingsbundleVersionSet59 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.bundleVersion = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Status Bar Hidden" )]
	class PlayerSettingsstatusBarHiddenGet60 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.statusBarHidden;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Status Bar Hidden" )]
	class PlayerSettingsstatusBarHiddenSet60 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.statusBarHidden = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Stripping Level" )]
	class PlayerSettingsstrippingLevelGet61 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.StrippingLevel Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.strippingLevel;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Stripping Level" )]
	class PlayerSettingsstrippingLevelSet61 : Automation {

		public UnityEditor.StrippingLevel Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.strippingLevel = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Strip Engine Code" )]
	class PlayerSettingsstripEngineCodeGet62 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.stripEngineCode;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Strip Engine Code" )]
	class PlayerSettingsstripEngineCodeSet62 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.stripEngineCode = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Default Interface Orientation" )]
	class PlayerSettingsdefaultInterfaceOrientationGet63 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.UIOrientation Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.defaultInterfaceOrientation;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Default Interface Orientation" )]
	class PlayerSettingsdefaultInterfaceOrientationSet63 : Automation {

		public UnityEditor.UIOrientation Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.defaultInterfaceOrientation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Portrait" )]
	class PlayerSettingsallowedAutorotateToPortraitGet64 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToPortrait;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Portrait" )]
	class PlayerSettingsallowedAutorotateToPortraitSet64 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToPortrait = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Portrait Upside Down" )]
	class PlayerSettingsallowedAutorotateToPortraitUpsideDownGet65 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Portrait Upside Down" )]
	class PlayerSettingsallowedAutorotateToPortraitUpsideDownSet65 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Landscape Right" )]
	class PlayerSettingsallowedAutorotateToLandscapeRightGet66 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Landscape Right" )]
	class PlayerSettingsallowedAutorotateToLandscapeRightSet66 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Allowed Autorotate To Landscape Left" )]
	class PlayerSettingsallowedAutorotateToLandscapeLeftGet67 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Allowed Autorotate To Landscape Left" )]
	class PlayerSettingsallowedAutorotateToLandscapeLeftSet67 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use Animated Autorotation" )]
	class PlayerSettingsuseAnimatedAutorotationGet68 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.useAnimatedAutorotation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use Animated Autorotation" )]
	class PlayerSettingsuseAnimatedAutorotationSet68 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.useAnimatedAutorotation = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Use 32 Bit Display Buffer" )]
	class PlayerSettingsuse32BitDisplayBufferGet69 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.use32BitDisplayBuffer;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Use 32 Bit Display Buffer" )]
	class PlayerSettingsuse32BitDisplayBufferSet69 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.use32BitDisplayBuffer = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Api Compatibility Level" )]
	class PlayerSettingsapiCompatibilityLevelGet70 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ApiCompatibilityLevel Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.apiCompatibilityLevel;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Api Compatibility Level" )]
	class PlayerSettingsapiCompatibilityLevelSet70 : Automation {

		public UnityEditor.ApiCompatibilityLevel Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.apiCompatibilityLevel = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Strip Unused Mesh Components" )]
	class PlayerSettingsstripUnusedMeshComponentsGet71 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.stripUnusedMeshComponents;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Strip Unused Mesh Components" )]
	class PlayerSettingsstripUnusedMeshComponentsSet71 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.stripUnusedMeshComponents = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Advanced License" )]
	class PlayerSettingsadvancedLicenseGet72 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.advancedLicense;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Get Aot Options" )]
	class PlayerSettingsaotOptionsGet73 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.aotOptions;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Aot Options" )]
	class PlayerSettingsaotOptionsSet73 : Automation {

		public System.String Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.aotOptions = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Accelerometer Frequency" )]
	class PlayerSettingsaccelerometerFrequencyGet74 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.accelerometerFrequency;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Accelerometer Frequency" )]
	class PlayerSettingsaccelerometerFrequencySet74 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.accelerometerFrequency = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get MT Rendering" )]
	class PlayerSettingsMTRenderingGet75 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.MTRendering;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set MT Rendering" )]
	class PlayerSettingsMTRenderingSet75 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.MTRendering = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mobile MT Rendering" )]
	class PlayerSettingsmobileMTRenderingGet76 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.mobileMTRendering;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Player Settings/Set Mobile MT Rendering" )]
	class PlayerSettingsmobileMTRenderingSet76 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.mobileMTRendering = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Rendering Path" )]
	class PlayerSettingsrenderingPathGet77 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.renderingPath;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Rendering Path" )]
	class PlayerSettingsrenderingPathSet77 : Automation {

		public UnityEngine.RenderingPath Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.renderingPath = Value;
			yield break;
		}

	}

	[Automation( "Player Settings/Get Mobile Rendering Path" )]
	class PlayerSettingsmobileRenderingPathGet78 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderingPath Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.mobileRenderingPath;
			yield break;
		}

	}

	[Automation( "Player Settings/Set Mobile Rendering Path" )]
	class PlayerSettingsmobileRenderingPathSet78 : Automation {

		public UnityEngine.RenderingPath Value;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.mobileRenderingPath = Value;
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
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
		[Editor.Serialization.IgnoreSerialization]
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

	[Automation( "Player Settings/Get Stack Trace Log Type" )]
	class PlayerSettingsGetStackTraceLogType20 : Automation {

		public UnityEngine.LogType logType;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.StackTraceLogType Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.PlayerSettings.GetStackTraceLogType(logType);
			yield break;
		}

	}

	[Automation( "Player Settings/Set Stack Trace Log Type" )]
	class PlayerSettingsSetStackTraceLogType21 : Automation {

		public UnityEngine.LogType logType;
		public UnityEngine.StackTraceLogType stackTraceType;

		public override IEnumerator Execute() {
			UnityEditor.PlayerSettings.SetStackTraceLogType(logType,stackTraceType);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif