using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubtractor : MonoBehaviour {

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ScoreManager2.GetInstance().AddScore(-2);
            Debug.Log(ScoreManager2.GetInstance().GetScore());
        }
    }
}
