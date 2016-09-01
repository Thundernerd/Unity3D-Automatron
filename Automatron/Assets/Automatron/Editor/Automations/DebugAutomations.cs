using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Debug/Get Developer Console Visible" )]
	class DebugdeveloperConsoleVisibleGet0 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Debug.isDebugBuild;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Debug/Draw Line" )]
	class DebugDrawLine0 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.Color color;
		public System.Single duration;
		public System.Boolean depthTest;

		public override IEnumerator Execute() {
			UnityEngine.Debug.DrawLine(start,end,color,duration,depthTest);
			yield break;
		}

	}

	[Automation( "Debug/Draw Ray" )]
	class DebugDrawRay1 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 dir;
		public UnityEngine.Color color;
		public System.Single duration;
		public System.Boolean depthTest;

		public override IEnumerator Execute() {
			UnityEngine.Debug.DrawRay(start,dir,color,duration,depthTest);
			yield break;
		}

	}

	[Automation( "Debug/Log" )]
	class DebugLog2 : Automation {

		public System.Object message;
		public UnityEngine.Object context;

		public override IEnumerator Execute() {
			UnityEngine.Debug.Log(message,context);
			yield break;
		}

	}

	[Automation( "Debug/Log Format" )]
	class DebugLogFormat3 : Automation {

		public UnityEngine.Object context;
		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogFormat(context,format,args);
			yield break;
		}

	}

	[Automation( "Debug/Log Error" )]
	class DebugLogError4 : Automation {

		public System.Object message;
		public UnityEngine.Object context;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogError(message,context);
			yield break;
		}

	}

	[Automation( "Debug/Log Error Format" )]
	class DebugLogErrorFormat5 : Automation {

		public UnityEngine.Object context;
		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogErrorFormat(context,format,args);
			yield break;
		}

	}

	[Automation( "Debug/Clear Developer Console" )]
	class DebugClearDeveloperConsole6 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Debug.ClearDeveloperConsole();
			yield break;
		}

	}

	[Automation( "Debug/Log Exception" )]
	class DebugLogException7 : Automation {

		public System.Exception exception;
		public UnityEngine.Object context;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogException(exception,context);
			yield break;
		}

	}

	[Automation( "Debug/Log Warning" )]
	class DebugLogWarning8 : Automation {

		public System.Object message;
		public UnityEngine.Object context;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarning(message,context);
			yield break;
		}

	}

	[Automation( "Debug/Log Warning Format" )]
	class DebugLogWarningFormat9 : Automation {

		public UnityEngine.Object context;
		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarningFormat(context,format,args);
			yield break;
		}

	}


#pragma warning restore 0649
}
