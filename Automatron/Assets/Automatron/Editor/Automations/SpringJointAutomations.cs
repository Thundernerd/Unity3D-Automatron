#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Spring Joint/Get Spring" )]
	class SpringJointspringGet0 : Automation {

		public UnityEngine.SpringJoint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spring;
			yield break;
		}

	}

	[Automation( "Spring Joint/Set Spring" )]
	class SpringJointspringSet0 : Automation {

		public UnityEngine.SpringJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spring = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint/Get Damper" )]
	class SpringJointdamperGet1 : Automation {

		public UnityEngine.SpringJoint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.damper;
			yield break;
		}

	}

	[Automation( "Spring Joint/Set Damper" )]
	class SpringJointdamperSet1 : Automation {

		public UnityEngine.SpringJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.damper = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint/Get Min Distance" )]
	class SpringJointminDistanceGet2 : Automation {

		public UnityEngine.SpringJoint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minDistance;
			yield break;
		}

	}

	[Automation( "Spring Joint/Set Min Distance" )]
	class SpringJointminDistanceSet2 : Automation {

		public UnityEngine.SpringJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minDistance = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint/Get Max Distance" )]
	class SpringJointmaxDistanceGet3 : Automation {

		public UnityEngine.SpringJoint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxDistance;
			yield break;
		}

	}

	[Automation( "Spring Joint/Set Max Distance" )]
	class SpringJointmaxDistanceSet3 : Automation {

		public UnityEngine.SpringJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxDistance = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint/Get Tolerance" )]
	class SpringJointtoleranceGet4 : Automation {

		public UnityEngine.SpringJoint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.tolerance;
			yield break;
		}

	}

	[Automation( "Spring Joint/Set Tolerance" )]
	class SpringJointtoleranceSet4 : Automation {

		public UnityEngine.SpringJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.tolerance = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif