using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovePenguin : MonoBehaviour
{
	public float speed;
    public float jumpForce;
    public Rigidbody body;
    float timer = 0f;
    public bool notStarted = true;
    public GameObject startButton;
    public GameObject gameOverButton;
    float startX = 0;
    public float displacement;
    bool hold = true;
 //   public Animator gameOverAnimator;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
        startX = body.position.x;
        gameOverButton.SetActive(false);
    }

    public void Started(){
        notStarted = false;
        startButton.SetActive(false);  
        timer = Time.time; 
    }

    public void reloadScene(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update(){

        if(notStarted){
            body.velocity = Vector3.zero;
        }

        if(body.position.x > startX + displacement || body.position.x < startX - displacement){
            body.velocity = Vector3.zero;
            gameOverButton.SetActive(true);
     //       gameOverAnimator.SetBool("isDead",true);

        }
    }

   void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name.Substring(0, 4) == "Cube") {
         body.AddForce(new Vector3(Random.Range(-3.0f, 3.0f), 0, 0), ForceMode.Impulse);
        } else if(col.gameObject.name.Substring(0, 5) == "LeftC") {
           body.AddForce(new Vector3(Random.Range(5.0f, 8.0f), 0, 0), ForceMode.Impulse);
        } else if(col.gameObject.name.Substring(0, 6) == "RightC") {
           body.AddForce(new Vector3(Random.Range(-5.0f, -8.0f), 0, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        if ((Time.time - timer > 5.0f) && !notStarted){
            hold = false;
        }

        if(!hold){
        if(!notStarted){
        body.AddForce(Input.GetAxis("Horizontal") * speed, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.UpArrow) && (Time.time - timer > 1.0f)){
                body.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                timer = Time.time;
        }
        }
        }
    }
}
