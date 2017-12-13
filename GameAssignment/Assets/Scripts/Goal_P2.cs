using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal_P2 : MonoBehaviour {


	private   LevelManager   levelManager;
	private Goal_P1 p1_gamesWon;


	private int p2_score = 0;
	public Text p2_score_text;
    private int p2_gamesWon = 0;
 
    public Text winner_Text;

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
            p2_gamesWon = p2_gamesWon + 1;
            p1_gamesWon = p1_gamesWon;
		}

		if (SceneManager.GetActiveScene ().name == "Level_2" && p2_score == 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
            p2_gamesWon = p2_gamesWon + 1;
            p1_gamesWon = p1_gamesWon;
		}

		if (SceneManager.GetActiveScene ().name == "Level_3" && p2_score == 3) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
            p2_gamesWon = p2_gamesWon + 1;
            p1_gamesWon = p1_gamesWon ;
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
        if (SceneManager.GetActiveScene().name == "End" && p2_gamesWon >= 2){
            winner_Text.text = ("Player 2");
        }
        if (SceneManager.GetActiveScene ().name == "End" && p2_gamesWon <= 1) {
            winner_Text.text = ("Player 1");
        } 
	}
}
