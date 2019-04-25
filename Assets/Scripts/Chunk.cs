using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
	public List<Transform> obstaclesSpawnLocations;

	public GameObject[] obstacles;

	public Transform obstaclesParent;

	public int minObstaclesToSpawn;
	public int maxObstaclesToSpawn;

	public void Start() {
		// destroy any existing obstacles on this game object when it spawn in
		foreach( Transform child in obstaclesParent ) {
			Destroy( child.gameObject );
		}

		// create new ones
		int numObstaclesToSpawn = Random.Range( minObstaclesToSpawn, Mathf.Min( maxObstaclesToSpawn, obstaclesSpawnLocations.Count ) + 1 );

		print( "Chunk " + name + " spawning " + numObstaclesToSpawn + " obstacles" );
		List<Transform> availableObstacleLocations = new List<Transform>( obstaclesSpawnLocations );
		for( int index = 0; index < numObstaclesToSpawn; index++ ) {
			GameObject newObstacle = Instantiate<GameObject>( obstacles[Random.Range(0, obstacles.Length)] );
			Transform whereToPutObstacle = availableObstacleLocations[Random.Range(0, availableObstacleLocations.Count)];
			newObstacle.transform.position = whereToPutObstacle.position;
			newObstacle.transform.parent = obstaclesParent;

			availableObstacleLocations.Remove( whereToPutObstacle );

			print( "Spawning new obstacle " + newObstacle.name + " at spawn location " + whereToPutObstacle.gameObject.name );
		}
	}
}
