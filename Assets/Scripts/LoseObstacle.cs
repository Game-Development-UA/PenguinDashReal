using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
	public GameObject loseUI;
	public PenguinAnimatorController death;

	void OnTriggerEnter( Collider col ) {
		MovePenguin player = col.gameObject.GetComponent<MovePenguin>();

		if( player != null && !player.dead) {
			player.body.isKinematic = true;

			death.die();
			Instantiate<GameObject>( loseUI );
		}
	}
}
