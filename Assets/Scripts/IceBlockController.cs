using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlockController : MonoBehaviour
{
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
    	//body.position = new Vector3(Random.Range(-3.0f, 3.0f), 3, 0);
        body.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
