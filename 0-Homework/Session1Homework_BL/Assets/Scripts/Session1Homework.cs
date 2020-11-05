using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    //i. Declare a int variable and set a value
    public int WholeNumber001 = 5;
    public int WholeNumber002 = 101;


    //ii. Declare a float variable and set a value
    public float DecimalNumber001 = 1.222222f;
    public float DecimalNumber002 = 2.333333f;


    //iii. Declare a string variable and set a value
    //String text
    private string WordsInside = "Let's do some work together.";
    public string WordsThatShows = "I'm Boning Luo. Nice to meet you.";


    //Logical
    private bool WannaCreateANewWorld = false;
    public bool WannaDestroyThisWorld = true;


    //iv. Create a function that prints the declared variables
    public int CalculatorSum001(int _FirstNumber, int _SecondNumber)
    {
        int SumResult001 = _FirstNumber + _SecondNumber;
        return SumResult001;
    }
    public float CalculatorSum002(float _FirstFloat, float _SecondFloat)
    {
        float SumResult002 = _FirstFloat + _SecondFloat;
        return SumResult002;
    }
    private void Start()
    {
        int SumResult001 = CalculatorSum001(WholeNumber001, WholeNumber002);
        UnityEngine.Debug.Log("Adding two whole numbers result is: " + SumResult001.ToString() + ".");

        float SumResult002 = CalculatorSum002(DecimalNumber001, DecimalNumber002);
        UnityEngine.Debug.Log("Adding two numbers result is: " + SumResult002.ToString() + ".");

    }



    //v. Declare and initialize an array
    public int[] WholeNumberCollections001 = { 5, 6, 7 };
    public float[] DecimalNumberCollections001 = { 0.1f, 0.2f, 0.3f };


    //vi. Declare and initialize a list
    public List<string> SuicideSquad = new List<string> { "Enchantress", "Katana", "Killer Croc", "Captain Boomerang", "Deadshot", "Harley Quinn" };

    //vii. Create and initialize a Dictionary
    public void update()
    {
        var AMdict = new Dictionary<int, string>();

        AMdict.Add(1, "Captain America");
        AMdict.Add(2, "Ironman");

        foreach (var entry in AMdict)
        {
            UnityEngine.Debug.Log(entry.Value[1]);
            UnityEngine.Debug.Log(entry.Value[2]);
        }
    }
}



   

        
