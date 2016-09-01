using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Application/Get Is Playing" )]
	class ApplicationisPlayingGet0 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Editor" )]
	class ApplicationisEditorGet1 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.isEditor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Web Player" )]
	class ApplicationisWebPlayerGet2 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.isWebPlayer;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Platform" )]
	class ApplicationplatformGet3 : Automation {

		[ReadOnly]
		public UnityEngine.RuntimePlatform Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.platform;
			yield break;
		}

	}

	[Automation( "Application/Get Is Mobile Platform" )]
	class ApplicationisMobilePlatformGet4 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.isMobilePlatform;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Console Platform" )]
	class ApplicationisConsolePlatformGet5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.isConsolePlatform;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Run In Background" )]
	class ApplicationrunInBackgroundGet6 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.runInBackground;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Set Run In Background" )]
	class ApplicationrunInBackgroundSet6 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Application.runInBackground = Value;
			yield break;
		}

	}

	[Automation( "Application/Get Data Path" )]
	class ApplicationdataPathGet7 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.dataPath;
			yield break;
		}

	}

	[Automation( "Application/Get Streaming Assets Path" )]
	class ApplicationstreamingAssetsPathGet8 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.streamingAssetsPath;
			yield break;
		}

	}

	[Automation( "Application/Get Persistent Data Path" )]
	class ApplicationpersistentDataPathGet9 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.persistentDataPath;
			yield break;
		}

	}

	[Automation( "Application/Get Temporary Cache Path" )]
	class ApplicationtemporaryCachePathGet10 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.temporaryCachePath;
			yield break;
		}

	}

	[Automation( "Application/Get Src Value" )]
	class ApplicationsrcValueGet11 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.srcValue;
			yield break;
		}

	}

	[Automation( "Application/Get Absolute URL" )]
	class ApplicationabsoluteURLGet12 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.absoluteURL;
			yield break;
		}

	}

	[Automation( "Application/Get Unity Version" )]
	class ApplicationunityVersionGet13 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.unityVersion;
			yield break;
		}

	}

	[Automation( "Application/Get Version" )]
	class ApplicationversionGet14 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.version;
			yield break;
		}

	}

	[Automation( "Application/Get Bundle Identifier" )]
	class ApplicationbundleIdentifierGet15 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.bundleIdentifier;
			yield break;
		}

	}

	[Automation( "Application/Get Install Mode" )]
	class ApplicationinstallModeGet16 : Automation {

		[ReadOnly]
		public UnityEngine.ApplicationInstallMode Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.installMode;
			yield break;
		}

	}

	[Automation( "Application/Get Sandbox Type" )]
	class ApplicationsandboxTypeGet17 : Automation {

		[ReadOnly]
		public UnityEngine.ApplicationSandboxType Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.sandboxType;
			yield break;
		}

	}

	[Automation( "Application/Get Product Name" )]
	class ApplicationproductNameGet18 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.productName;
			yield break;
		}

	}

	[Automation( "Application/Get Company Name" )]
	class ApplicationcompanyNameGet19 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.companyName;
			yield break;
		}

	}

	[Automation( "Application/Get Cloud Project Id" )]
	class ApplicationcloudProjectIdGet20 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.cloudProjectId;
			yield break;
		}

	}

	[Automation( "Application/Get Web Security Enabled" )]
	class ApplicationwebSecurityEnabledGet21 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.webSecurityEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Web Security Host Url" )]
	class ApplicationwebSecurityHostUrlGet22 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.webSecurityHostUrl;
			yield break;
		}

	}

	[Automation( "Application/Get Target Frame Rate" )]
	class ApplicationtargetFrameRateGet23 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.targetFrameRate;
			yield break;
		}

	}

	[Automation( "Application/Set Target Frame Rate" )]
	class ApplicationtargetFrameRateSet23 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Application.targetFrameRate = Value;
			yield break;
		}

	}

	[Automation( "Application/Get System Language" )]
	class ApplicationsystemLanguageGet24 : Automation {

		[ReadOnly]
		public UnityEngine.SystemLanguage Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.systemLanguage;
			yield break;
		}

	}

	[Automation( "Application/Get Background Loading Priority" )]
	class ApplicationbackgroundLoadingPriorityGet25 : Automation {

		[ReadOnly]
		public UnityEngine.ThreadPriority Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.backgroundLoadingPriority;
			yield break;
		}

	}

	[Automation( "Application/Set Background Loading Priority" )]
	class ApplicationbackgroundLoadingPrioritySet25 : Automation {

		public UnityEngine.ThreadPriority Value;

		public override IEnumerator Execute() {
			UnityEngine.Application.backgroundLoadingPriority = Value;
			yield break;
		}

	}

	[Automation( "Application/Get Internet Reachability" )]
	class ApplicationinternetReachabilityGet26 : Automation {

		[ReadOnly]
		public UnityEngine.NetworkReachability Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Application.internetReachability;
			yield break;
		}

	}

	[Automation( "Application/Get Genuine" )]
	class ApplicationgenuineGet27 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.genuine;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Genuine Check Available" )]
	class ApplicationgenuineCheckAvailableGet28 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.genuineCheckAvailable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Get Is Showing Splash Screen" )]
	class ApplicationisShowingSplashScreenGet29 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Application.HasProLicense();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Application/Open URL" )]
	class ApplicationOpenURL5 : Automation {

		public System.String url;

		public override IEnumerator Execute() {
			UnityEngine.Application.OpenURL(url);
			yield break;
		}

	}


#pragma warning restore 0649
}
