using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("Start Score : " + ScoreManager2.GetInstance().GetScore());
    }
    void Update () {
	if(Input.GetMouseButtonDown(0))
        {
            ScoreManager2.GetInstance().AddScore(5);
            Debug.Log(ScoreManager2.GetInstance().GetScore());
        }
	}
}
