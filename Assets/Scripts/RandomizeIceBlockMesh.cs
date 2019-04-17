using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeIceBlockMesh : MonoBehaviour
{
	public Material mat1;
 	public Material mat2;
	enum iceMaterial {Mat1, Mat2};
	int enumMat = Random.Range(1,3);
	iceMaterial myMat;
  //  mats = GetComponent<Renderer>().Materials;

    // Start is called before the first frame update
    void Start()
    {
    	if(enumMat > 1){
    		myMat = iceMaterial.Mat2;
    	} else {
    		myMat = iceMaterial.Mat1;
    	}


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
