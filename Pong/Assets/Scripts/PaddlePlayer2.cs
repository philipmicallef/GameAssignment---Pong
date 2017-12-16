using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		

        // Finding the playable screen height for the paddle
        float mousePosInBlocks = (Input.mousePosition.y / Screen.height * 5) -2.5f;

        //Setting paddle position
		Vector3   paddlePosition   =   new   Vector3(this.transform.position.x,   0.5f,   0f); 
		
        //Mapping paddle movement to mouse movement
		paddlePosition.y   =   mousePosInBlocks;

        this.transform.position = paddlePosition;

	}
}
