using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Whatever : MonoBehaviour {

    public Text textBox;

        int max = 100;
        int min = 1;
        int guess;
        private int counter;

	// Use this for initialization
	void Start () {

        guess = Random.Range(min, max);

        textBox.text = "Welcome to Number Guesser\nnew line test "
        + "\nPick a number in your head"
        + "\n\nThe highest number you can pick is " + max
        + "\nThe lowest number you can pick is " + min
        + "\n\nIs the number higher or lower than " + guess
        + "\n up arrow for higher, Down for lower, Enter for equal";

        max = max + 1;
        print("Welcome to Number Guesser");
        print("Pick a number in your head");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is 1" + min);

        print("Is the number higher or lower than " + guess);
        print("Up arrow for higher, Down for lower, Enter for equal");
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {

            min = guess;
            guess = (max + min) / 2;
            counter--;
            print("Is the number higher or lower than " + guess);


        }
        if (Input.GetKeyUp (KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            counter--;
            print("Is the number higher or lower than " + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I Win");
        }
            if (counter == 0);
        {
            //counter--;
            //print("You Win");

            if (Input.GetKeyDown(KeyCode.Return)) ;
            {
                print("I win");
            }
            if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                //counter--;
                print("You win!");
            }
        }


            //when counter reaches zero then computer wins
        }
        }

            
        
	

