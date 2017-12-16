using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    private PaddlePlayer1 myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If game started and ball colides -> play sound effect
        if (hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
        }

        //If ball hits wall -> increase velocity
		if (collision.gameObject.name == "Wall")
		{
			randomY = Random.Range(0f, 1f);
			Vector2 tweak = new Vector2(randomX, randomY);
			this.GetComponent<Rigidbody2D>().velocity += tweak;
		}

        // If ball enters player 1's goal -> reset ball
		if (collision.gameObject.name == "P1_Score")
		{
			hasStarted = false;
		}

        //If ball enters player 2's goal -> reset ball
		if (collision.gameObject.name == "P2_Score")
        {
			hasStarted = false;
		}

        // Keep increasing velocity
		else
		{
			Vector2 tweak = new Vector2(randomX, randomY);
			this.GetComponent<Rigidbody2D>().velocity += tweak;
		}
    }

    // Use this for initialization
    void Start()
    {

        randomX = Random.Range(0f, 0.10f);
        randomY = Random.Range(0f, 0.10f);

        //attaches the object itself rather than
        //having to attach the Paddle myself
        //from Unity
        myPaddle = GameObject.FindObjectOfType<PaddlePlayer1>();

        //save the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted) //if hasStarted == false
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0)) //left click
            {
                hasStarted = true;

                //applies a velocity to the ball
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(15f, 3f);

				if (SceneManager.GetActiveScene ().name == "Level_2") {
					this.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 3f);
				}

				if (SceneManager.GetActiveScene ().name == "Level_3") {
					this.GetComponent<Rigidbody2D>().velocity = new Vector2(30f, 3f);
				}
            }
        }

    }
}
