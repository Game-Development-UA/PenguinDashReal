using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{

	public WorldTile[] tiles;
	public Transform bumpers;
	public int numTiles;
	float runningHeight = 20f;
	public Rigidbody body;
	public Transform bodyT;

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
			bumperRender.position = new Vector3(0f, bodyT.position.y, runningHeight + bodyT.position.z + 10);
			newTile.transform.position = new Vector3(0f, bodyT.position.y, runningHeight + bodyT.position.z);
			runningHeight += Random.Range(45f, 60f);
		}    	
    }
}
