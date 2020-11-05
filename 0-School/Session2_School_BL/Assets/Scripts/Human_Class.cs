using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

//Namespace
namespace RC3Humans
{
    public class Human_Class
    {
        // Variables
        string name;
        float height;
        string countryOfOrigin;

        // Constructor
        public Human_Class(string _name, float _height)
        {
            name = _name;
            height = _height;
            SetClothing();
        }

        // Behaviors (Functions)
        public string GetName()
        {
            return name;
        }

        public float GetHeight()
        {
            return height;
        }

        public void GetCountryOfOrigin(string _countryOfOrigin)
        {
            countryOfOrigin = _countryOfOrigin;
        }

        private void Sleep()
        {
            //Actions
            //Brush the teeth
            //Change into PJs
            //Make bed
        }

        public void Walking()
        {
            //Action
        }

        public void WorkOut()
        {
            //Action
        }

        private void SetClothing()
        {
            //Action
        }
    }

    
}
