using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    private void Start()
    {
        onCalculate = sum;
        onCalculate += sub;
    }

    public float sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float sub(float a, float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float mul(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //sum(1,10)이 실행된다. 하지만 Caculator는 이를 알필요가 없다. 
            onCalculate(1,10); 
        } 
    }
}
