using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class MovePenguin : MonoBehaviour
{
	public float speed;
    public float jumpForce;
    public float jumpInterval;
    public float shootInterval;
    public Rigidbody body;
    float jumpTimer = 0f;
    float runTimer = 0f;
    float shootTimer = 0f;
    Animator myAnimator;
    public GameObject Target;
    public bool dead = false;
    public bool started = false;
    bool isRunning = false;
    public PenguinAnimatorController penguinAnimator;


    float xInput;

    public void Start(){
    }


    void Update(){
        if(!dead && started){
            xInput = Input.GetAxis("Horizontal");
            if( runTimer > jumpInterval ){
                if(!isRunning){
                    penguinAnimator.run();
                    isRunning = true;
                }
            }


        if( Input.GetKeyDown(KeyCode.UpArrow) && jumpTimer > jumpInterval ) {
            isRunning = false;
            penguinAnimator.jump();
            body.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            jumpTimer = 0f;
            runTimer = 0f;
        }

        if( Input.GetKeyDown(KeyCode.Space) && shootTimer > shootInterval ) {
            isRunning = false;
            penguinAnimator.attack();
            shootTimer = 0f;
            runTimer = 0f;
        }

        runTimer += Time.deltaTime;
        jumpTimer += Time.deltaTime;
        shootTimer += Time.deltaTime;
    }
    }

    void FixedUpdate() {
                body.AddForce(xInput * speed, 0f, 0f);
    }
}
