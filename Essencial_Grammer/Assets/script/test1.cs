using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour {

    public BaseMonster[] monster;

    private void Start()
    {
        for(int i =0; i<monster.Length;i++)
        {
            Debug.Log(monster[i].gameObject.name); 
        }
    }
}
