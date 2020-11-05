using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Session2_School_BL : MonoBehaviour
{
    // Color Names Array
    string[] colors = { "red", "green", "blue", "yellow", "fuchsia" };

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log(colors[1]);

        // Loops
        // For loop(counter, end condition, step)
        for (int counter = 0; counter < colors.Length; counter = counter + 1)
        {
            UnityEngine.Debug.Log("The current color at position " + counter);
            UnityEngine.Debug.Log(" " + colors[counter]);
        }

        int sumOfOddNumbers = 0;

        for (int i = 1; i < 100; i = i + 2)
        {
            sumOfOddNumbers += i;
        }
        UnityEngine.Debug.Log("All odd numbers to 100 added together is: " + sumOfOddNumbers + ".");

        // Shorthand for loop, can only go over the whole collection
        foreach(string currentColor in colors)
        {
            UnityEngine.Debug.Log("Going over the rainbow with " + currentColor);
        }

        // While loop (needs a condition to end)
        int WhileCounter = 0;
        string rainbow = "Rainbow colors: ";
        while(WhileCounter < colors.Length)
        {
            rainbow += colors[WhileCounter] + " ";
            WhileCounter++;
        }
        UnityEngine.Debug.Log(rainbow);

        //Conditionals (asking the computer questions)
        //If statement (has 2 branches, one for true, one for false. false branch is optional.)
        for(int i = 0; i <= 20; i++)
        {
            if(i%2 == 0)
            {
                UnityEngine.Debug.Log("Whole number: " + i);
            }
            //else is optional
            else
            {
                UnityEngine.Debug.Log("Odd number: " + i);
            }
        }

        // Asking multiple questions
        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        // Two conditions met (Concatenation)
        if(question1Answer && question2Answer)
        {
            // Instruction here
            UnityEngine.Debug.Log("Both answers are true.");
        }

        // One condition is met from 2 questions
        if(question1Answer || question2Answer )
        {
            UnityEngine.Debug.Log("One of the answers is true.");
        }

        // More than 2 questions
        if(question1Answer || question2Answer || question3Answer)
        {
            // Action here
        }

        //Question in question
        if(question1Answer == true)
        {
            if(question2Answer == true)
            {
                if(question3Answer == false)
                {
                    UnityEngine.Debug.Log("Question 1&2 are true, question 3 is flase.");
                }
            }
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
