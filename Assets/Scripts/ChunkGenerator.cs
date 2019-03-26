using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
	public GameObject nextChunk;
	public DestroyAfter parent;
	public Transform nextChunkSpawnLoc;
	public WorldController gen;
	bool hasGenerated = false;

	void OnTriggerEnter( Collider otherCol ) {
		if(!hasGenerated){
			GameObject newChunk = Instantiate<GameObject>( nextChunk );
			newChunk.transform.position = nextChunkSpawnLoc.position;
			newChunk.transform.rotation = nextChunkSpawnLoc.rotation;
			gen.Generate();
			parent.Destroy();
			hasGenerated = true;
		}
	}
}
