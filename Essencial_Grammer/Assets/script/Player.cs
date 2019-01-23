using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float Hp = 50f;

    public int gold = 1000;

    private void OnTriggerEnter(Collider other)
    {
        PlayerItem playerItem = other.GetComponent<PlayerItem>();

        if(playerItem != null)
        {
            playerItem.Use();
        }
    }
}
