using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private PaddlePlayer1 myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
        }

		if (collision.gameObject.name == "Wall")
		{
			randomY = Random.Range(0f, 1f);
			Vector2 tweak = new Vector2(randomX, randomY);
			this.GetComponent<Rigidbody2D>().velocity += tweak;
		}
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

                //applies a velocity of 2x and 10 y to the ball
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(15f, 3f);


            }
        }

    }
}
