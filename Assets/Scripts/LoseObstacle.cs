using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
	public GameObject loseUI;

	void OnTriggerEnter( Collider col ) {
		MovePenguin player = col.gameObject.GetComponent<MovePenguin>();

		if( player != null ) {
			player.body.isKinematic = true;

			Instantiate<GameObject>( loseUI );
		}
	}
}
