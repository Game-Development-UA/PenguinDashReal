﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGunSound : MonoBehaviour
{

	public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(){
    	sound.Play();
    }

    public void StopSound(){
    	sound.Stop();
    }
}
