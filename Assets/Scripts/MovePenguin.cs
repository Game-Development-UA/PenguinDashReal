using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePenguin : MonoBehaviour
{
	public float speed;
    public float jumpForce;
    public Rigidbody body;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.AddForce(Input.GetAxis("Horizontal") * speed, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.UpArrow) && (Time.time - timer > 1.0f)){
                body.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                timer = Time.time;
        }
    }
}
