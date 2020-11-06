using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Session2Homework_BL : MonoBehaviour
{
    private string[] avangerMembers = { "Steve Rogers", "Tony Stark", "Bruce Banner", "Thor Odinson" };

    // Start is called before the first frame update
    void Start()
    {
        //i. Write a function that uses a condition
        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 == 0)
            {
                UnityEngine.Debug.Log("A multiplier of 3: " + i);
            }
            else
            {
                UnityEngine.Debug.Log(i + " is not a multiplier of 3.");
            }
        }

        //ii. Write a for loop
        for (int counter = 0; counter < avangerMembers.Length; counter = counter + 1 )
        {
            UnityEngine.Debug.Log("Avenger Member Number " + (counter + 1)  + " is " + avangerMembers[counter]);
        }
        //iii. Write a dog class and initialize an instance of the class
        // In Dog_Class, CyberDog, Dog_Handler
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
