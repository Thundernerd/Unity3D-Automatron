using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Application/Get Streamed Bytes" )]
	class ApplicationstreamedBytesGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.streamedBytes;
			yield break;
		}

	}

	[Automation( "Application/Get Is Playing" )]
	class ApplicationisPlayingGet1 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Editor" )]
	class ApplicationisEditorGet2 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isEditor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Web Player" )]
	class ApplicationisWebPlayerGet3 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isWebPlayer;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Platform" )]
	class ApplicationplatformGet4 : Automation {

		[ReadOnly]
		public UnityEngine.RuntimePlatform Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.platform;
			yield break;
		}

	}

	[Automation( "Application/Get Is Mobile Platform" )]
	class ApplicationisMobilePlatformGet5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isMobilePlatform;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Console Platform" )]
	class ApplicationisConsolePlatformGet6 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isConsolePlatform;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Run In Background" )]
	class ApplicationrunInBackgroundGet7 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.runInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Set Run In Background" )]
	class ApplicationrunInBackgroundSet7 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Application.runInBackground = Value;
			yield break;
		}

	}

	[Automation( "Application/Get Data Path" )]
	class ApplicationdataPathGet8 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.dataPath;
			yield break;
		}

	}

	[Automation( "Application/Get Streaming Assets Path" )]
	class ApplicationstreamingAssetsPathGet9 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.streamingAssetsPath;
			yield break;
		}

	}

	[Automation( "Application/Get Persistent Data Path" )]
	class ApplicationpersistentDataPathGet10 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.persistentDataPath;
			yield break;
		}

	}

	[Automation( "Application/Get Temporary Cache Path" )]
	class ApplicationtemporaryCachePathGet11 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.temporaryCachePath;
			yield break;
		}

	}

	[Automation( "Application/Get Src Value" )]
	class ApplicationsrcValueGet12 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.srcValue;
			yield break;
		}

	}

	[Automation( "Application/Get Absolute URL" )]
	class ApplicationabsoluteURLGet13 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.absoluteURL;
			yield break;
		}

	}

	[Automation( "Application/Get Unity Version" )]
	class ApplicationunityVersionGet14 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.unityVersion;
			yield break;
		}

	}

	[Automation( "Application/Get Version" )]
	class ApplicationversionGet15 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.version;
			yield break;
		}

	}

	[Automation( "Application/Get Bundle Identifier" )]
	class ApplicationbundleIdentifierGet16 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.bundleIdentifier;
			yield break;
		}

	}

	[Automation( "Application/Get Install Mode" )]
	class ApplicationinstallModeGet17 : Automation {

		[ReadOnly]
		public UnityEngine.ApplicationInstallMode Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.installMode;
			yield break;
		}

	}

	[Automation( "Application/Get Sandbox Type" )]
	class ApplicationsandboxTypeGet18 : Automation {

		[ReadOnly]
		public UnityEngine.ApplicationSandboxType Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.sandboxType;
			yield break;
		}

	}

	[Automation( "Application/Get Product Name" )]
	class ApplicationproductNameGet19 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.productName;
			yield break;
		}

	}

	[Automation( "Application/Get Company Name" )]
	class ApplicationcompanyNameGet20 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.companyName;
			yield break;
		}

	}

	[Automation( "Application/Get Cloud Project Id" )]
	class ApplicationcloudProjectIdGet21 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.cloudProjectId;
			yield break;
		}

	}

	[Automation( "Application/Get Web Security Enabled" )]
	class ApplicationwebSecurityEnabledGet22 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.webSecurityEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Web Security Host Url" )]
	class ApplicationwebSecurityHostUrlGet23 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.webSecurityHostUrl;
			yield break;
		}

	}

	[Automation( "Application/Get Target Frame Rate" )]
	class ApplicationtargetFrameRateGet24 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.targetFrameRate;
			yield break;
		}

	}

	[Automation( "Application/Set Target Frame Rate" )]
	class ApplicationtargetFrameRateSet24 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Application.targetFrameRate = Value;
			yield break;
		}

	}

	[Automation( "Application/Get System Language" )]
	class ApplicationsystemLanguageGet25 : Automation {

		[ReadOnly]
		public UnityEngine.SystemLanguage Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.systemLanguage;
			yield break;
		}

	}

	[Automation( "Application/Get Genuine" )]
	class ApplicationgenuineGet26 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.genuine;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Genuine Check Available" )]
	class ApplicationgenuineCheckAvailableGet27 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.genuineCheckAvailable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Showing Splash Screen" )]
	class ApplicationisShowingSplashScreenGet28 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.isShowingSplashScreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Quit" )]
	class ApplicationQuit0 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Application.Quit();
			yield break;
		}

	}

	[Automation( "Application/Cancel Quit" )]
	class ApplicationCancelQuit1 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Application.CancelQuit();
			yield break;
		}

	}

	[Automation( "Application/Capture Screenshot" )]
	class ApplicationCaptureScreenshot2 : Automation {

		public System.String filename;
		public System.Int32 superSize;

		public override IEnumerator Execute() {
			UnityEngine.Application.CaptureScreenshot(filename,superSize);
			yield break;
		}

	}

	[Automation( "Application/Has Pro License" )]
	class ApplicationHasProLicense4 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.HasProLicense();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Request Advertising Identifier Async" )]
	class ApplicationRequestAdvertisingIdentifierAsync5 : ConditionalAutomation {

		public UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.RequestAdvertisingIdentifierAsync(delegateMethod);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Open URL" )]
	class ApplicationOpenURL6 : Automation {

		public System.String url;

		public override IEnumerator Execute() {
			UnityEngine.Application.OpenURL(url);
			yield break;
		}

	}

	[Automation( "Application/Has User Authorization" )]
	class ApplicationHasUserAuthorization7 : ConditionalAutomation {

		public UnityEngine.UserAuthorization mode;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.HasUserAuthorization(mode);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
