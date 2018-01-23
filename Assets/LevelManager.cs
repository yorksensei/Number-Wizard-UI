using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string scene) {
		Debug.Log("Level load requested for " + scene);
		SceneManager.LoadScene (scene, LoadSceneMode.Single);	
	}

	public void QuitRequest() {
		Debug.Log("Quit requested");
		Application.Quit ();
	}
}
