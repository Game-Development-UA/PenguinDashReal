using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class MovePenguin : MonoBehaviour
{
	public float speed;
    public float jumpForce;
    public float jumpInterval;
    public Rigidbody body;
    float jumpTimer = 0f;
    // float countTimer = 0f;
    // public bool notStarted = true;
    // public GameObject startButton;
    // public GameObject gameOverButton;
    // float startX = 0;
    // public float displacement;
    // bool hold = true;
    // bool oneVis = false;
    // bool twoVis = false;
    // bool threeVis = false;
    // bool scoreVis = false;
    // bool goVis = false;
    // public GameObject one;
    // public GameObject two;
    // public GameObject three;
    // public GameObject go;
    // public ScoreKeeper scoreKeeper;
    // public GameObject scoreKeeperObject;
    // float score = 0;

    float xInput;



 //   public Animator gameOverAnimator;

    // Start is called before the first frame update
    // void Start()
    // {
    //     timer = Time.time;
    //     startX = body.position.x;
    //     gameOverButton.SetActive(false);
    //     one.SetActive(false);
    //     two.SetActive(false);
    //     three.SetActive(false);
    //     go.SetActive(false);
        // scoreKeeperObject.SetActive(false);
      //  scoreKeeper.active = false;
    // }

    // public void Started(){
        // notStarted = false;
        // startButton.SetActive(false);  
        // timer = Time.time;
        // countTimer = Time.time; 
        // oneVis = true;
    // }

    // public void reloadScene(){
    //      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }

    void Update(){

     //    if(oneVis == true && Time.time - countTimer < 1.0f){
     //        one.active = true;
     //    }else if(oneVis == true && Time.time - countTimer >= 1.0f){
     //        one.active = false;
     //        oneVis = false;
     //        twoVis = true;
     //        countTimer = Time.time;
     //    }

     //    if(twoVis == true && Time.time - countTimer < 1.0f){
     //        two.active = true;
     //    }else if(twoVis == true && Time.time - countTimer >= 1.0f){
     //        two.active = false;
     //        twoVis = false;
     //        threeVis = true;
     //        countTimer = Time.time;
     //    }

     //    if(threeVis == true && Time.time - countTimer < 1.0f){
     //        three.active = true;
     //    }else if(threeVis == true && Time.time - countTimer >= 1.0f){
     //        three.active = false;
     //        threeVis = false;
     //        countTimer = Time.time;
     //        goVis = true;
     //    }

     //    if(goVis == true && Time.time - countTimer < 2.0f){
     //        go.active = true;
     //    }else if(goVis == true && Time.time - countTimer >= 2.0f){
     //        goVis = false;
     //        go.active = false;
     //        scoreVis = true;
     //      //  scoreKeeper.active = true;
     //        // scoreKeeperObject.SetActive(true);
     //    }

     //    if(notStarted){
     //        body.velocity = Vector3.zero;
     //    }

     //    if(body.position.x > startX + displacement || body.position.x < startX - displacement){
     //        body.velocity = Vector3.zero;
     //        gameOverButton.SetActive(true);
     // //       gameOverAnimator.SetBool("isDead",true);
     //    }

        // if(scoreVis == true){
        //     score += body.velocity.magnitude;
        //     scoreKeeper.UpdateScore((int) score);
        // }
        xInput = Input.GetAxis("Horizontal");

        if( Input.GetKeyDown(KeyCode.UpArrow) && jumpTimer > jumpInterval ) {
            body.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            jumpTimer = 0f;
        }

        jumpTimer += Time.deltaTime;
    }

    // void OnCollisionEnter(Collision col){
    //     if(col.gameObject.name.Substring(0,4) == "Cube")
    //     {
            
    //     }
    // }

    void FixedUpdate() {
        // if ((Time.time - timer > 5.0f) && !notStarted){
        //     hold = false;
        // }

        // if(!hold){
        //     if(!notStarted){
                body.AddForce(xInput * speed, 0f, 0f);
                
        //     }
        // }
    }
}
