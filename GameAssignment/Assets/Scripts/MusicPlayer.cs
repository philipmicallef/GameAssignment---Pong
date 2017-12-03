using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	//static   variables   are   shared   across   all   instances   of   a   class
	static   MusicPlayer   myMusicPlayer   =   null;


	void Awake()
	{
		//if   myMusicPlayer   already   exists
		if (myMusicPlayer != null) {
			//Destroy   the   new   object   immediately
			Destroy (this.gameObject);
			print ("Duplicate   music   player   self-destructing");
		}

		//else if   myMusicPlayer   is   null
		else {

			//myMusicPlayer   is   this   object   and   it   is   no   longer   null                                   
			myMusicPlayer = this;

			//gameObject = musicPlayerObject with all its components the gameObject that this script is attached to music   keeps   on   playing   while   browsing   the   scenes
			GameObject.DontDestroyOnLoad (gameObject);

		}
	}



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}
}
