using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 12;
	
	
	public Text guessText;
	
	void Start () {
		StartGame();
	}
	
	void StartGame(){
	
		max = 1000;
		min = 1;
		
		// randomly creating a new first guess each game
		NextGuess();

		
		// printing the game in console 
	
		print ("==========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	
	}
	
	void NextGuess(){
		// choose random numbers between max and min range instead of halfing it predictably each time
		
		guess = Random.Range(min, max+1);
		guessText.text = guess.ToString();
		maxGuessesAllowed--;
		
		// if the computer has gone over the alotted guesses, the player wins
		if (maxGuessesAllowed <=0){
			Application.LoadLevel("Win");
		}
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
}
