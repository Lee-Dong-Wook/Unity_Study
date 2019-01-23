﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Worker : MonoBehaviour {

    Action work; 

    void MoveBricks()
    {
        Debug.Log("벽돌을 옮겻다");
    }

    void DigIn()
    {
        Debug.Log("땅을 팟다");
    }

    private void Start()
    {
        work += MoveBricks;
        work += DigIn;

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            work();
        }
    }
}
