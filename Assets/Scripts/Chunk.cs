using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
	public List<Transform> obstaclesSpawnLocations;

	public GameObject[] obstacles;

	public int minObstaclesToSpawn;
	public int maxObstaclesToSpawn;

	public void CreateObstacles() {
		int numObstaclesToSpawn = Random.Range( minObstaclesToSpawn, Mathf.Min( maxObstaclesToSpawn, obstaclesSpawnLocations.Count ) + 1 );
		List<Transform> availableObstacleLocations = new List<Transform>( obstaclesSpawnLocations );
		for( int index = 0; index < numObstaclesToSpawn; index++ ) {
			GameObject newObstacle = Instantiate<GameObject>( obstacles[Random.Range(0, obstacles.Length)] );
			Transform whereToPutObstacle = availableObstacleLocations[Random.Range(0, availableObstacleLocations.Count)];
			newObstacle.transform.position = whereToPutObstacle.position;

			availableObstacleLocations.Remove( whereToPutObstacle );
		}
	}
}
