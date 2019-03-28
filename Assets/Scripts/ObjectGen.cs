using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGen : MonoBehaviour
{

	public WorldController gen;

	void OnTriggerEnter( Collider otherCol ) {
			gen.Generate();
		}

}
