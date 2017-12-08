using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public void LoadLevel(string name)
	{
		print ("Level Load requested for " + name);
		SceneManager.LoadScene (name);
	}

	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuitGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
