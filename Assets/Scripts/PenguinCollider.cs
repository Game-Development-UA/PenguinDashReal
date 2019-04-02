using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollider : MonoBehaviour
{
    public PenguinAnimatorController penguinAnimator;
   	public GameObject loseUI;
   	public MovePenguin penguin;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
    	if(!penguin.dead){	
    			if(collision.gameObject.name.Substring(0,4) == "Cube"){	
       			penguinAnimator.die();
       			Instantiate<GameObject>( loseUI );
       			penguin.dead = true;
       		}
       }
    }
}
