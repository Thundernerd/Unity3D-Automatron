using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Nav Mesh Obstacle/Get Height" )]
	class NavMeshObstacleheightGet0 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Height" )]
	class NavMeshObstacleheightSet0 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Radius" )]
	class NavMeshObstacleradiusGet1 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Radius" )]
	class NavMeshObstacleradiusSet1 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Velocity" )]
	class NavMeshObstaclevelocityGet2 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Velocity" )]
	class NavMeshObstaclevelocitySet2 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.velocity = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Carving" )]
	class NavMeshObstaclecarvingGet3 : ConditionalAutomation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.carving;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Obstacle/Set Carving" )]
	class NavMeshObstaclecarvingSet3 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.carving = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Carve Only Stationary" )]
	class NavMeshObstaclecarveOnlyStationaryGet4 : ConditionalAutomation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.carveOnlyStationary;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Nav Mesh Obstacle/Set Carve Only Stationary" )]
	class NavMeshObstaclecarveOnlyStationarySet4 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.carveOnlyStationary = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Carving Move Threshold" )]
	class NavMeshObstaclecarvingMoveThresholdGet5 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.carvingMoveThreshold;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Carving Move Threshold" )]
	class NavMeshObstaclecarvingMoveThresholdSet5 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.carvingMoveThreshold = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Carving Time To Stationary" )]
	class NavMeshObstaclecarvingTimeToStationaryGet6 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.carvingTimeToStationary;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Carving Time To Stationary" )]
	class NavMeshObstaclecarvingTimeToStationarySet6 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.carvingTimeToStationary = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Shape" )]
	class NavMeshObstacleshapeGet7 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public UnityEngine.NavMeshObstacleShape Result;

		public override IEnumerator Execute() {
			Result = Instance.shape;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Shape" )]
	class NavMeshObstacleshapeSet7 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public UnityEngine.NavMeshObstacleShape Value;

		public override IEnumerator Execute() {
			Instance.shape = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Center" )]
	class NavMeshObstaclecenterGet8 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Center" )]
	class NavMeshObstaclecenterSet8 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Get Size" )]
	class NavMeshObstaclesizeGet9 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Nav Mesh Obstacle/Set Size" )]
	class NavMeshObstaclesizeSet9 : Automation {

		public UnityEngine.NavMeshObstacle Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
