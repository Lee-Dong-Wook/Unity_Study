using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public delegate void Boost(Character target);

    public event Boost playerBoost; 

    public string playerName = "Raynor";

    public float hp = 100f;

    public float defense = 50f;

    public float damage = 30f;

    private void Start()
    {
        playerBoost(this);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerBoost(this);
        }
    }
}
