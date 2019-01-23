using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloArray : MonoBehaviour {

	void Start () {

        int[] scores = new int[10];

        scores[0]=1;
        scores[1]=2;
        scores[2]=3;
        scores[3]=4;
        scores[4]=5;
        scores[5]=6;
        scores[6]=7;
        scores[7]=8;
        scores[8]=9;
        scores[9]=10;

        for(int i = 0; i < 10; i++) { Debug.Log("score["+i+"] = "+scores[i]);  }
    }	
}
