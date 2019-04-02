using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinAnimatorController : MonoBehaviour
{
	Animator myAnimator;
    public GameObject Target;
    public MovePenguin player;
    public PlayDeathSound deathSound;
    // Start is called before the first frame update
    void Start()
    {
    	myAnimator = Target.GetComponent<Animator> ();
    }

	public void run(){
		myAnimator.SetBool("run", true);
	}

	public void jump(){
		myAnimator.SetBool("jump", true);
	}

	public void attack(){
		myAnimator.SetBool("attack_01", true);
	}

	public void die(){
		myAnimator.SetBool("die", true);
		deathSound.PlaySound();
		player.dead = true;
	}
}
