using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
	public GameObject nextChunk;
	// public DestroyAfter parent;
	public Transform nextChunkSpawnLoc;

	void OnTriggerEnter( Collider otherCol ) {
		MovePenguin player = otherCol.gameObject.GetComponent<MovePenguin>();

		if( player != null ) {
			GameObject newChunk = Instantiate<GameObject>( nextChunk );
			newChunk.transform.position = nextChunkSpawnLoc.position;
			// newChunk.transform.rotation = nextChunkSpawnLoc.rotation;
			// parent.Destroy();
		}
	}
}
