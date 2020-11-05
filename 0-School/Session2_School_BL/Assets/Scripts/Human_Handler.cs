using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using RC3Humans;

public class Human_Handler : MonoBehaviour
{
    // Variables
    Human_Class John, Mary, Jason;
    Cyborg JohnCyborg;

    // Start is called before the first frame update
    void Start()
    {
        John = new Human_Class("John Smith", 1.81f);
        Mary = new Human_Class("Mary Liu", 1.65f);
        Jason = new Human_Class("Jason Wong", 1.79f);
        JohnCyborg = new Cyborg("CyJo", 1.81f);
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(John.GetName());
        John.Walking();
        John.WorkOut();
        JohnCyborg.Scan();

    }
}
