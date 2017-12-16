using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal_P1 : MonoBehaviour {


	private   LevelManager   levelManager;
                   
	public static int p1_score = 0;

	public Text p1_score_text;

	private int p1_gamesWon = 0;
    private int p2_gamesWon = 0;
	public Text winner_Text;




		void   OnTriggerEnter2D(Collider2D   collider) 
        {
            print("Collision with " + gameObject.name);
		}
		
		//this   is   triggered   when   a   collision happens with Player 2's Goal Post
		void   OnCollisionEnter2D(Collision2D   collision)
		{
			print ("Score !!");
			p1_score++;
			SetCountText ();
	            
			if (SceneManager.GetActiveScene ().name == "Level_1" && p1_score == 3) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				p1_gamesWon++;
                p2_gamesWon = p2_gamesWon;
				p1_score = 0;
			}

			if (SceneManager.GetActiveScene ().name == "Level_2" && p1_score == 3) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				p1_gamesWon++;
                p2_gamesWon = p2_gamesWon;
				p1_score = 0;
			}

			if (SceneManager.GetActiveScene ().name == "Level_3" && p1_score == 3) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				p1_gamesWon++;
                p2_gamesWon = p2_gamesWon;
			}
			
		}
		// Use this for initialization
		void Start () {
			levelManager = GameObject.FindObjectOfType<LevelManager>();

		}

        //Setting Score to string 
		void SetCountText()
		{
			p1_score_text.text = "Player 1 Score: " + p1_score.ToString ();
		}
		
		// Update is called once per frame
		void Update () {
			if (SceneManager.GetActiveScene ().name == "End" && p1_gamesWon >= 2) {
				winner_Text.text = ("Player 1");
				print ("P1 win");
            //Reset
                p1_score = 0;
			}
		
            if (SceneManager.GetActiveScene().name == "End" && p1_gamesWon <= 1)
            {
                winner_Text.text = ("Player 2");
				print ("p2 win");
            //Reset
                Goal_P2.p2_score = 0;

            }

		}
}
