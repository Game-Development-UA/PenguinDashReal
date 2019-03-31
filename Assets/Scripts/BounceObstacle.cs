using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObstacle : MonoBehaviour
{
	public float bounce;

	void OnCollisionEnter( Collision col ) {
		MovePenguin player = col.gameObject.GetComponent<MovePenguin>();

		if( player != null ) {
			player.body.AddForce(new Vector3(Random.Range(-bounce, bounce), 0, 0), ForceMode.Impulse);
		}
	}
}
