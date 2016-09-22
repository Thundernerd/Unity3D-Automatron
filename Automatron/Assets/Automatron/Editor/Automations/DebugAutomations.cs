#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Debug/Get Developer Console Visible" )]
	class DebugdeveloperConsoleVisibleGet0 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Debug.developerConsoleVisible;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Debug/Set Developer Console Visible" )]
	class DebugdeveloperConsoleVisibleSet0 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Debug.developerConsoleVisible = Value;
			yield break;
		}

	}

	[Automation( "Debug/Get Is Debug Build" )]
	class DebugisDebugBuildGet1 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Debug.isDebugBuild;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Debug/Log" )]
	class DebugLog0 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.Log(message);
			yield break;
		}

	}

    [Automation( "Debug/Log Message" )]
    class DebugLogMessage : Automation {

        public string message;

        public override IEnumerator Execute() {
            UnityEngine.Debug.Log( message );
            yield break;
        }

    }

    [Automation( "Debug/Log Format" )]
	class DebugLogFormat1 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogFormat(format,args);
			yield break;
		}

	}

	[Automation( "Debug/Log Error" )]
	class DebugLogError2 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogError(message);
			yield break;
		}

	}

    [Automation( "Debug/Log Error Message" )]
    class DebugLogErrorMessage : Automation {

        public string message;

        public override IEnumerator Execute() {
            UnityEngine.Debug.LogError( message );
            yield break;
        }

    }

    [Automation( "Debug/Log Error Format" )]
	class DebugLogErrorFormat3 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogErrorFormat(format,args);
			yield break;
		}

	}

	[Automation( "Debug/Log Exception" )]
	class DebugLogException4 : Automation {

		public System.Exception exception;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogException(exception);
			yield break;
		}

	}

	[Automation( "Debug/Log Warning" )]
	class DebugLogWarning5 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarning(message);
			yield break;
		}

	}

    [Automation( "Debug/Log Warning Message" )]
    class DebugLogWarningMessage : Automation {

        public string message;

        public override IEnumerator Execute() {
            UnityEngine.Debug.LogWarning( message );
            yield break;
        }

    }

    [Automation( "Debug/Log Warning Format" )]
	class DebugLogWarningFormat6 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarningFormat(format,args);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif