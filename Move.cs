using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float move = 5.0f;

    // Use this for initialization
    void Start () {

        


    }
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float xPos = h * move;
        transform.position = new Vector3(xPos, .5f, 0);

    }
}
