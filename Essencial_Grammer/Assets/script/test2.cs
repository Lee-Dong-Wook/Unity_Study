using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {

    public PointManager pointManager;

    public MonsterManager monsterManager; 

	void Start () {

         pointManager.point = 100;
        Debug.Log("현재 점수 : " + pointManager.point);

        pointManager.point = -100;
        Debug.Log("현재 점수 : " + pointManager.point);

        Debug.Log(monsterManager.count); //변수같지만 사실 get{} 통해 얻는다. 
    }	
}
