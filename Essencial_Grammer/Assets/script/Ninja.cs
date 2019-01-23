using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour {

    public static Ninja NinjaKing;

    public string ninjaName;

    public bool isKing;

    private void Start()
    {
        if(isKing)
        {
            NinjaKing = this; //isKing이 true면 자기자신을 NinjaKing으로 한다. 
        }
    }
    private void Update()
    {
        Debug.Log("My name : " + ninjaName + "NinjaKing : " + NinjaKing);
    }
}
