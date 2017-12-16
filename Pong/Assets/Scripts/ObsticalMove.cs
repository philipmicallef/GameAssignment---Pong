using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalMove : MonoBehaviour {
	
	public int maxSpeed;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		
        //Setting initial speed and inital starting position of object( in this case Obsticals)
		maxSpeed = 2;

		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        //Calling..
		MoveUp ();
	}

    //As time goes by the objects will move accordingly  
	void MoveUp(){
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

		if(transform.position.y > 1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
		else if(transform.position.y < -1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
	

