using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
	public Vector3 forceDir;

	void OnCollisionEnter( Collision col ) {
		print( "Bumper hit " + col.gameObject.name );
		if( col.gameObject.name == "Penguin" ) {
			col.rigidbody.AddForce( forceDir, ForceMode.Impulse );
		}
	}
}
