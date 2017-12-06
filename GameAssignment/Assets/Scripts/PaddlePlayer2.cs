using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//this   should   print   in   the   console   the   position   of   the   cursor


        float mousePosInBlocks = (Input.mousePosition.y / Screen.height * 5) -2.5f;

		Vector3   paddlePosition   =   new   Vector3(this.transform.position.x,   0.5f,   0f); 
		

		paddlePosition.y   =   mousePosInBlocks;

        this.transform.position = paddlePosition;

	}
}
