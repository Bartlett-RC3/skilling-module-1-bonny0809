using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Session2HomeworkDog
{
    public class Dog_Class
    {
        string name;
        float weight;
        string color;

        public Dog_Class(string _name, float _weight, string _color)
        {
            name = _name;
            weight = _weight;
            color = _color;
        }
            
        public string GetName()
        {
            return name;
        }

        public float GetWeight()
        {
            return weight;
        }

        public string GetColor()
        {
            return color;
        }

        public void Sleep()
        {
            //Action
        }

        public void Eat()
        {
            //Action
        }

        public void Walk()
        {
            //Action
        }
    }
}

