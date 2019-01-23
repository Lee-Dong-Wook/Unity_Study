﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour {

    public UnityEvent onPlayerDead; 

    private void Dead()
    {
        onPlayerDead.Invoke();//UnityEvent 실행 

        Debug.Log("죽었땅");
        Destroy(gameObject); 
    }

    private void OnTriggerEnter(Collider other)
    {
        Dead();
    }
}
