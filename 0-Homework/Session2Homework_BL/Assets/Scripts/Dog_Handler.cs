using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Session2HomeworkDog;
using System;

public class Dog_Handler : MonoBehaviour
{
    Dog_Class goofy, pluto;
    CyberDog goofyCyborg;

    // Start is called before the first frame update
    void Start()
    {
        goofy = new Dog_Class("Goofy", 80.5f, "black");
        pluto = new Dog_Class("Pluto", 52.5f, "yellow-orange");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Name: " + goofy.GetName());
        Debug.Log("Color of " + goofy.GetName() + " is: " + goofy.GetColor());
        goofy.Sleep();
        goofy.Eat();
        goofy.Walk();
        
    }
}
