﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    // Start is called before the first frame update
	public int afterTime;

    void Start()
    {
    }

    public void Destroy(){
       Destroy(this.gameObject, afterTime); 
    }
}
