using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int maxNumber = 1000;
    private int minNumber = 1;
    private int guessCount = 0;
    private int guess;

    void Start()
    {
        WelcomeMessage();
        TakeNumber();
    }

    void Update()
    {
        ListenForInput();
    }

    private void WelcomeMessage() {
        Debug.Log("Welcome to Number Wizard!");
    }

	private void TakeNumber() {
        Debug.Log("Please pick a number between");
        Debug.Log("Minimally " + minNumber + " and");
        Debug.Log("Maximally " + maxNumber + ":");
        MakeGuess();
    }

    private void MakeGuess() {
        guessCount++;
        CalculateGuess();
    }

	private void CalculateGuess() {
        //account for odd / 2 integer rounding
        if (minNumber == 999 && maxNumber == 1000) { 
            maxNumber++;
        }
		//although this would normally be enough
        guess = (minNumber + maxNumber) / 2;
        StateGuess();
	}

	private void ListenForInput() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Higher();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Lower();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            Correct();
        }
    }

	private void Higher() {
        Debug.Log("You pressed Up, which means Higher.");
        minNumber = guess;
        MakeGuess();
    }

	private void Lower() {
        Debug.Log("You pressed Down, which means Lower.");
        maxNumber = guess;
        MakeGuess();
    }

	private void Correct() {
        Debug.Log("============================");
        Debug.Log("Happy to have guessed right.");
        Debug.Log("============================");

        maxNumber = 1000;
        minNumber = 1;
        guessCount = 0;
        TakeNumber();
    }

    private void StateGuess() {
        Debug.Log("My guess number " + guessCount + " is: " + guess);
        Debug.Log("Is your number higher or lower?");
        Debug.Log("Press Up = Higer, Press Down = Lower, Enter = Correct.");
    }
}
