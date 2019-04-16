using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeLifeTime : MonoBehaviour
{
    public int life;
    void Start()
    {
        Destroy(this.gameObject, life);
    }
}
