using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer1 : MonoBehaviour {


	public float speed;

	private Rigidbody2D rb;

	private Ball ball;

	float maxY = 4f;

	float minY = -8f;

	// Use this for initialization
	void Start () {

		ball = GameObject.FindObjectOfType<Ball>();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (transform.position.y >= 4f) {
			this.transform.position = new Vector3 (this.transform.position.x, maxY, 0);
		 
		}

		if (transform.position.y <= 4f) {
			this.transform.position = new Vector3 (this.transform.position.x, minY, 0);
		
		}
		*/

		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * Time.deltaTime * 6f, 0);
		
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * Time.deltaTime * 6f, 0);
		
		}
	}
}
