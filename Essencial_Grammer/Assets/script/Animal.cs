using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal  {

    public string name;

    public float weight;

    public int year; 

    public void Print()
    {
        Debug.Log(name + " | 몸무게 : " + weight  + " | 나이 : " + year);
    }

    protected float getSpeed()
    {
        return CalcSpeed();
    }

    private float CalcSpeed()
    {
        return 100f / (weight * year);
    }

}

public class Wolf : Animal
{
    public void Hunt()
    {
        float speed = getSpeed();
        Debug.Log(speed + "의 속도로 달려가 사냥했다.");

        weight = weight + 10f; 
    }
}

public class Lion : Animal
{
    public void hide()
    {
        Debug.Log("숨었당");
    }
}
