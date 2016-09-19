#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Nav Mesh Agent/Get Destination" )]
	class NavMeshAgentdestinationGet0 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.destination;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Stopping Distance" )]
	class NavMeshAgentstoppingDistanceGet1 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.stoppingDistance;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Stopping Distance" )]
	class NavMeshAgentstoppingDistanceSet1 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.stoppingDistance = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Velocity" )]
	class NavMeshAgentvelocityGet2 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Velocity" )]
	class NavMeshAgentvelocitySet2 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.velocity = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Next Position" )]
	class NavMeshAgentnextPositionGet3 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.nextPosition;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Next Position" )]
	class NavMeshAgentnextPositionSet3 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.nextPosition = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Steering Target" )]
	class NavMeshAgentsteeringTargetGet4 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.steeringTarget;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Desired Velocity" )]
	class NavMeshAgentdesiredVelocityGet5 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.desiredVelocity;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Remaining Distance" )]
	class NavMeshAgentremainingDistanceGet6 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.remainingDistance;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Base Offset" )]
	class NavMeshAgentbaseOffsetGet7 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.baseOffset;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Base Offset" )]
	class NavMeshAgentbaseOffsetSet7 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.baseOffset = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Is On Off Mesh Link" )]
	class NavMeshAgentisOnOffMeshLinkGet8 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isOnOffMeshLink;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Get Current Off Mesh Link Data" )]
	class NavMeshAgentcurrentOffMeshLinkDataGet9 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.OffMeshLinkData Result;

		public override IEnumerator Execute() {
			Result = Instance.currentOffMeshLinkData;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Next Off Mesh Link Data" )]
	class NavMeshAgentnextOffMeshLinkDataGet10 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.OffMeshLinkData Result;

		public override IEnumerator Execute() {
			Result = Instance.nextOffMeshLinkData;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Auto Traverse Off Mesh Link" )]
	class NavMeshAgentautoTraverseOffMeshLinkGet11 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoTraverseOffMeshLink;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Auto Traverse Off Mesh Link" )]
	class NavMeshAgentautoTraverseOffMeshLinkSet11 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoTraverseOffMeshLink = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Auto Braking" )]
	class NavMeshAgentautoBrakingGet12 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoBraking;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Auto Braking" )]
	class NavMeshAgentautoBrakingSet12 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoBraking = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Auto Repath" )]
	class NavMeshAgentautoRepathGet13 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoRepath;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Auto Repath" )]
	class NavMeshAgentautoRepathSet13 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoRepath = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Has Path" )]
	class NavMeshAgenthasPathGet14 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasPath;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Get Path Pending" )]
	class NavMeshAgentpathPendingGet15 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.pathPending;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Get Is Path Stale" )]
	class NavMeshAgentisPathStaleGet16 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPathStale;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Get Path Status" )]
	class NavMeshAgentpathStatusGet17 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.NavMeshPathStatus Result;

		public override IEnumerator Execute() {
			Result = Instance.pathStatus;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Path End Position" )]
	class NavMeshAgentpathEndPositionGet18 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.pathEndPosition;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Path" )]
	class NavMeshAgentpathGet19 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.NavMeshPath Result;

		public override IEnumerator Execute() {
			Result = Instance.path;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Area Mask" )]
	class NavMeshAgentareaMaskGet20 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.areaMask;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Area Mask" )]
	class NavMeshAgentareaMaskSet20 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.areaMask = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Speed" )]
	class NavMeshAgentspeedGet21 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.speed;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Speed" )]
	class NavMeshAgentspeedSet21 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.speed = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Angular Speed" )]
	class NavMeshAgentangularSpeedGet22 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularSpeed;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Angular Speed" )]
	class NavMeshAgentangularSpeedSet22 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularSpeed = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Acceleration" )]
	class NavMeshAgentaccelerationGet23 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.acceleration;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Acceleration" )]
	class NavMeshAgentaccelerationSet23 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.acceleration = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Update Position" )]
	class NavMeshAgentupdatePositionGet24 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.updatePosition;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Update Position" )]
	class NavMeshAgentupdatePositionSet24 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.updatePosition = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Update Rotation" )]
	class NavMeshAgentupdateRotationGet25 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.updateRotation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Update Rotation" )]
	class NavMeshAgentupdateRotationSet25 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.updateRotation = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Radius" )]
	class NavMeshAgentradiusGet26 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Radius" )]
	class NavMeshAgentradiusSet26 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Height" )]
	class NavMeshAgentheightGet27 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Height" )]
	class NavMeshAgentheightSet27 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Obstacle Avoidance Type" )]
	class NavMeshAgentobstacleAvoidanceTypeGet28 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ObstacleAvoidanceType Result;

		public override IEnumerator Execute() {
			Result = Instance.obstacleAvoidanceType;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Obstacle Avoidance Type" )]
	class NavMeshAgentobstacleAvoidanceTypeSet28 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.ObstacleAvoidanceType Value;

		public override IEnumerator Execute() {
			Instance.obstacleAvoidanceType = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Avoidance Priority" )]
	class NavMeshAgentavoidancePriorityGet29 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.avoidancePriority;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Avoidance Priority" )]
	class NavMeshAgentavoidancePrioritySet29 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.avoidancePriority = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Is On Nav Mesh" )]
	class NavMeshAgentisOnNavMeshGet30 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isOnNavMesh;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Destination" )]
	class NavMeshAgentSetDestination0 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SetDestination(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Activate Current Off Mesh Link" )]
	class NavMeshAgentActivateCurrentOffMeshLink1 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Boolean activated;

		public override IEnumerator Execute() {
			Instance.ActivateCurrentOffMeshLink(activated);
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Complete Off Mesh Link" )]
	class NavMeshAgentCompleteOffMeshLink2 : Automation {

		public UnityEngine.NavMeshAgent Instance;

		public override IEnumerator Execute() {
			Instance.CompleteOffMeshLink();
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Warp" )]
	class NavMeshAgentWarp3 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 newPosition;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Warp(newPosition);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Move" )]
	class NavMeshAgentMove4 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 offset;

		public override IEnumerator Execute() {
			Instance.Move(offset);
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Stop" )]
	class NavMeshAgentStop5 : Automation {

		public UnityEngine.NavMeshAgent Instance;

		public override IEnumerator Execute() {
			Instance.Stop();
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Resume" )]
	class NavMeshAgentResume6 : Automation {

		public UnityEngine.NavMeshAgent Instance;

		public override IEnumerator Execute() {
			Instance.Resume();
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Reset Path" )]
	class NavMeshAgentResetPath7 : Automation {

		public UnityEngine.NavMeshAgent Instance;

		public override IEnumerator Execute() {
			Instance.ResetPath();
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Set Path" )]
	class NavMeshAgentSetPath8 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.NavMeshPath path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SetPath(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Find Closest Edge" )]
	class NavMeshAgentFindClosestEdge9 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.NavMeshHit hit;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.FindClosestEdge(out hit);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Raycast" )]
	class NavMeshAgentRaycast10 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 targetPosition;
		public UnityEngine.NavMeshHit hit;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Raycast(targetPosition,out hit);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Calculate Path" )]
	class NavMeshAgentCalculatePath11 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public UnityEngine.Vector3 targetPosition;
		public UnityEngine.NavMeshPath path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.CalculatePath(targetPosition,path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Sample Path Position" )]
	class NavMeshAgentSamplePathPosition12 : ConditionalAutomation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Int32 areaMask;
		public System.Single maxDistance;
		public UnityEngine.NavMeshHit hit;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SamplePathPosition(areaMask,maxDistance,out hit);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Agent/Set Area Cost" )]
	class NavMeshAgentSetAreaCost13 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Int32 areaIndex;
		public System.Single areaCost;

		public override IEnumerator Execute() {
			Instance.SetAreaCost(areaIndex,areaCost);
			yield break;
		}

	}

	[Automation( "Nav Mesh Agent/Get Area Cost" )]
	class NavMeshAgentGetAreaCost14 : Automation {

		public UnityEngine.NavMeshAgent Instance;
		public System.Int32 areaIndex;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAreaCost(areaIndex);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif