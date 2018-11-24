using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabScript : MonoBehaviour {

    public Transform cubeEnd;
    public Rigidbody cubePrefab;
    

	// Use this for initialization
	void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody cubeInstance;
            cubeInstance = Instantiate
                (cubePrefab, cubeEnd.position, cubeEnd.rotation) 
                as Rigidbody;

            cubeInstance.AddForce(cubeEnd.forward * 2000);

           
        }

        
		
	}
}
