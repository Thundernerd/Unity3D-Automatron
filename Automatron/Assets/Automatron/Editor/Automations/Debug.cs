using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

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
	class DebugDrawRay7 : Automation {

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
	class DebugLog10 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.Log(message);
			yield break;
		}

	}

	[Automation( "Debug/Log Format" )]
	class DebugLogFormat12 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogFormat(format,args);
			yield break;
		}

	}

	[Automation( "Debug/Log Error" )]
	class DebugLogError14 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogError(message);
			yield break;
		}

	}

	[Automation( "Debug/Log Error Format" )]
	class DebugLogErrorFormat16 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogErrorFormat(format,args);
			yield break;
		}

	}

	[Automation( "Debug/Log Warning" )]
	class DebugLogWarning21 : Automation {

		public System.Object message;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarning(message);
			yield break;
		}

	}

	[Automation( "Debug/Log Warning Format" )]
	class DebugLogWarningFormat23 : Automation {

		public System.String format;
		public System.Object[] args;

		public override IEnumerator Execute() {
			UnityEngine.Debug.LogWarningFormat(format,args);
			yield break;
		}

	}


#pragma warning restore 0649
}
