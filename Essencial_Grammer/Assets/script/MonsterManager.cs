using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour {

    public int count
    {
        get {
            Monster[] monster = FindObjectsOfType<Monster>();

            return monster.Length;
        }
    }
}
