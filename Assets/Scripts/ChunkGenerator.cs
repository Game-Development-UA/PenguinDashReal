using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
	public GameObject nextChunk;
	public Transform nextChunkSpawnLoc;

	void OnTriggerEnter( Collider otherCol ) {
		GameObject newChunk = Instantiate<GameObject>( nextChunk );
		newChunk.transform.position = nextChunkSpawnLoc.position;
		newChunk.transform.rotation = nextChunkSpawnLoc.rotation;
	}
}
