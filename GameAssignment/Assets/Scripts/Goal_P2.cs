using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal_P2 : MonoBehaviour {


	private   LevelManager   levelManager;


	private int p2_score = 0;

	public Text p2_score_text;


	void   OnTriggerEnter2D(Collider2D   collider) 
	{
		print("Collision with " + gameObject.name);
	}

	//this   is   triggered   when   a   collision happens
	void   OnCollisionEnter2D(Collision2D   collision)   
	{
		
		print("Score !!");
		p2_score++;
		SetCountText ();

		if (SceneManager.GetActiveScene ().name == "Level_1" && p2_score == 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}

		if (SceneManager.GetActiveScene ().name == "Level_2" && p2_score == 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}

		if (SceneManager.GetActiveScene ().name == "Level_3" && p2_score == 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}

	}

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();

	}


	void SetCountText()
	{
		p2_score_text.text = "Player 2 Score: " + p2_score.ToString ();
	}

	// Update is called once per frame
	void Update () {

	}
}
