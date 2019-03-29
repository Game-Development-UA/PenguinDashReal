using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
	public MovePenguin player;
	public GameObject startUI;

	public void Begin() {
		player.body.isKinematic = false;

		Destroy( startUI );
	}
}
