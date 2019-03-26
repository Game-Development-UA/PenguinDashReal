using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{

	public WorldTile[] tiles;
	public Transform bumpers;
	public int numTiles;
	float runningHeight = 0f;
	public Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate(){
		for( int index = 0; index < numTiles; index++ ) {
			WorldTile randomTile = tiles[Random.Range(0, tiles.Length)];
			WorldTile newTile = Instantiate<WorldTile>( randomTile );
			Transform bumperRender = Instantiate<Transform>( bumpers );
			bumperRender.position = body.position + new Vector3(0f, 3f, runningHeight + 10);
			newTile.transform.position = body.position + new Vector3( 0f, 3f, runningHeight );
			runningHeight += 10;
		}    	
    }
}
