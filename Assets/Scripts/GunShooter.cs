using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooter : MonoBehaviour
{

	public int weaponRange;
	public float fireRate;
	RaycastHit hit;
	public Transform gunEnd;
    public Transform fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
  //  private AudioSource gunAudio;
    public LineRenderer laserLine;
    private float nextFire;
    public GameObject explodeEffectsPrefab;



	//Ray shootingRay = new Ray(transform,porition, new Vector)
    // Start is called before the first frame update
    void Start()
    {
        //laserLine = GetComponent<LineRenderer>();
        // gunAudio = GetComponent<AudioSource>();
        // fpsCam = GetComponentInParent<Camera> ();       
    }

    // Update is called once per frame
    void Update()
    {
     
		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire) {
		     nextFire = Time.time + fireRate;
		     StartCoroutine(ShotEffect());
		     Vector3 rayOrigin = gunEnd.position;// + new Vector3(0.0f, 0.0f, 4.0f);//fpsCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 4.0f));
             RaycastHit hit;
             //laserLine.SetPosition (0, gunEnd.position);

            if (Physics.Raycast (rayOrigin, gunEnd.forward, out hit, weaponRange)) {
               // laserLine.SetPosition (1, hit.point);
               // print(hit.rigidbody.name);
                if(hit.rigidbody.name.Substring(0,4) == "Cube"){
                	print(hit.rigidbody.name.Substring(0,4));
                	Instantiate(explodeEffectsPrefab, hit.rigidbody.position, hit.rigidbody.rotation);
                	Destroy(hit.rigidbody.gameObject);
                }

            }
            // else {
            //     laserLine.SetPosition (1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            // }
		}

    }

    private IEnumerator ShotEffect() {
    	//gunAudio.Play();
    	laserLine.enabled = true;
    	yield return shotDuration;
    	laserLine.enabled = false;
	}

}
