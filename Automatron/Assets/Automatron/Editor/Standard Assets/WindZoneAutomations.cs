using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Wind Zone/Get Mode" )]
	class WindZonemodeGet0 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public UnityEngine.WindZoneMode Result;

		public override IEnumerator Execute() {
			Result = Instance.mode;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Mode" )]
	class WindZonemodeSet0 : Automation {

		public UnityEngine.WindZone Instance;
		public UnityEngine.WindZoneMode Value;

		public override IEnumerator Execute() {
			Instance.mode = Value;
			yield break;
		}

	}

	[Automation( "Wind Zone/Get Radius" )]
	class WindZoneradiusGet1 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Radius" )]
	class WindZoneradiusSet1 : Automation {

		public UnityEngine.WindZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Wind Zone/Get Wind Main" )]
	class WindZonewindMainGet2 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.windMain;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Wind Main" )]
	class WindZonewindMainSet2 : Automation {

		public UnityEngine.WindZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.windMain = Value;
			yield break;
		}

	}

	[Automation( "Wind Zone/Get Wind Turbulence" )]
	class WindZonewindTurbulenceGet3 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.windTurbulence;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Wind Turbulence" )]
	class WindZonewindTurbulenceSet3 : Automation {

		public UnityEngine.WindZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.windTurbulence = Value;
			yield break;
		}

	}

	[Automation( "Wind Zone/Get Wind Pulse Magnitude" )]
	class WindZonewindPulseMagnitudeGet4 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.windPulseMagnitude;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Wind Pulse Magnitude" )]
	class WindZonewindPulseMagnitudeSet4 : Automation {

		public UnityEngine.WindZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.windPulseMagnitude = Value;
			yield break;
		}

	}

	[Automation( "Wind Zone/Get Wind Pulse Frequency" )]
	class WindZonewindPulseFrequencyGet5 : Automation {

		public UnityEngine.WindZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.windPulseFrequency;
			yield break;
		}

	}

	[Automation( "Wind Zone/Set Wind Pulse Frequency" )]
	class WindZonewindPulseFrequencySet5 : Automation {

		public UnityEngine.WindZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.windPulseFrequency = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
