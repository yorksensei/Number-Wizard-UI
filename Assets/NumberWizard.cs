using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int min, max, guess;
	public int maxGuessesAllowed = 5;
	public Text guessText;
	public Text remainingGuesses;
	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
		min = 1;
		NextGuess ();

	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	void NextGuess() {
		maxGuessesAllowed -= 1;
		guess = Random.Range(min, max + 1); //(max + min) / 2;
		guessText.text = guess.ToString();
		remainingGuesses.text = maxGuessesAllowed.ToString ();
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win", LoadSceneMode.Single);
		}
	}
}
