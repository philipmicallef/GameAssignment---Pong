using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_P1 : MonoBehaviour {


	public   LevelManager   levelManager;
		void   OnTriggerEnter2D(Collider2D   collider) {
			print("Trigger");

			//loads Next Scene when ball enteres Trigger
			levelManager.LoadLevel("Level_2");     
			
		}


		//this   is   triggered   when   a   collision happens
		void   OnCollisionEnter2D(Collision2D   collision)   
		{
			print("Collision");             
		}

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
		
	}
}
