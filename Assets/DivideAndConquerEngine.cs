using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquerEngine : MonoBehaviour {


    public int Guess;
    public int Max;
    public int Min;

	// Use this for initialization
	void Start () {
        Debug.Log("Welcome to Divide and Conquer game");
        Debug.Log("PIck a number in your mind. Let see how good you are hiding number");
        //Fancy way to format string :p
        Debug.Log(string.Format("The highest number you can pick is: {0} ", Max));
        //Normal way to format srting :)
        Debug.Log("The lowest number you can pick is:" + Min);
        Debug.Log("Is the number > or < than" + Guess + "?");
        //Debug.Log("Up arrow == >, Down arrow == <, Enter == equal");

        Debug.Log(string.Format("Up {1} {0} >{2} Down {1} {0} <{2} Enter {0} equal", "==", "arrow", ","));
    }
	
	// Update is called once per frame
	void Update () {
        Engine();
	}

    void Engine() {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Min = Guess;
            Algorithm();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            Max = Guess;
            Algorithm();
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I Won!!!");
        }
    }

    void Algorithm() {
        Guess = (Max + Min) / 2;
        Debug.Log("Higher > or lower than : " + Guess + " ?");
    }

}
