using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGunSound : MonoBehaviour
{
	public AudioSource sound;

    public void PlaySound(){
    	sound.Play();
    }

    public void StopSound(){
    	sound.Stop();
    }
}
