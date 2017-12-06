using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_P1 : MonoBehaviour {


	private   LevelManager   levelManager;

    int p1_score = 0;

		void   OnTriggerEnter2D(Collider2D   collider) 
        {
            print("Collision with " + gameObject.name);
		}


		//this   is   triggered   when   a   collision happens
		void   OnCollisionEnter2D(Collision2D   collision)   
		{
			print("Score !!");
            p1_score++;
            
		}

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {

	        if(p1_score == 3){
	            levelManager.LoadLevel("Level_2");
	        }
		}
}
