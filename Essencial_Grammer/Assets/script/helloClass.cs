using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animal jack = new Animal();
        jack.name = "jack";
        jack.sound = "bark";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "nate";
        nate.sound = "nya";
        nate.weight = 10f;

        Animal annie = new Animal();
        annie.name = "annie";
        annie.sound = "arrrrr";
        annie.weight = 100f;

        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(nate.name);
        Debug.Log(nate.sound);
        Debug.Log(annie.name);
        Debug.Log(annie.sound);

        nate = jack; //nate에 jack이 덮어 씌우기가 된다. 
        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(nate.name);
        Debug.Log(nate.sound);

        nate.name = "jimmy"; //nate의 이름을 jimmy로 바꾼다. 
                             //서로 독립적이기 때문에 nate의 이름은 바뀌지만 jack의 이름은 그대로 라고 생각가능. 

        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(nate.name);
        Debug.Log(nate.sound);
    }
	
	
    public class Animal //동물이라는 새로운 원형을 만든다. 
    {
       public string name;

       public string sound;

       public float weight; 
    }
}
