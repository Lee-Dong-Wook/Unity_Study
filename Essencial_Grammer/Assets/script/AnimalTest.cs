using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTest : MonoBehaviour {

    private void Start()
    {
        Wolf snow = new Wolf();
        snow.name = "snow";
        snow.weight = 50f;
        snow.year = 3;

        Lion hiko = new Lion();
        hiko.name = "hiko";
        hiko.weight = 40f;
        hiko.year = 5;

        Animal[] animals = new Animal[2];

        animals[0] = snow;
        animals[1] = hiko;

        for(int i =0; i<animals.Length;i++)
        {
            animals[i].Print();
        }
    }
}
