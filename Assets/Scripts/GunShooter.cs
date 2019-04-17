using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GunShooter : MonoBehaviour
{

	public int weaponRange;
	public float fireRate;
	RaycastHit hit;
	public Transform gunEnd;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    public LineRenderer laserLine;
    private float nextFire;
    public GameObject explodeEffectsPrefab;
    private Action<RaycastHit> gunAction;



	//Ray shootingRay = new Ray(transform,porition, new Vector)
    // Start is called before the first frame update
    void Start() {
         gunAction = handleCubeDestruction;
    }

    // Update is called once per frame
    void Update() {
     
		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire) {
		     nextFire = Time.time + fireRate;
		     StartCoroutine(ShotEffect());
		     Vector3 rayOrigin = gunEnd.position;
             RaycastHit hit;
             if (Physics.Raycast (rayOrigin, gunEnd.forward, out hit, weaponRange)) {
               // if(hit.rigidbody != null){
                    if(hit.rigidbody.name.Substring(0,4) == "Cube"){
                	   print(hit.rigidbody.name.Substring(0,4));
                        gunAction.Invoke(hit);
                    }
               //}
            }
		}

    }

    void handleCubeDestruction(RaycastHit hit) {
        Instantiate(explodeEffectsPrefab, hit.rigidbody.position, hit.rigidbody.rotation);
        Destroy(hit.rigidbody.gameObject);       
    }

    private IEnumerator ShotEffect() {
    	laserLine.enabled = true;
    	yield return shotDuration;
    	laserLine.enabled = false;
	}

}
