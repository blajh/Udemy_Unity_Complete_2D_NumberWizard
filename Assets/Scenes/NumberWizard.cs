using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int maxNumber = 1000;
    private int minNumber = 1;
    public int pickedNumber;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number between");
        Debug.Log("Minimally " + minNumber + " and");
        Debug.Log("Maximally " + maxNumber + ":");
        Debug.Log("Tell me if your number is higher or lower then 500.");
        Debug.Log("Press Up = Higer, Press Down = Lower, Enter = Correct.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("You pressed Up, which means Higher.");
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("You pressed Down, which means Lower.");
        }
    }


}
