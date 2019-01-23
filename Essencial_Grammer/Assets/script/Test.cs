using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
        Debug.Log("Test용 script 이다. ");
        Debug.Log("Dog의 총 갯수 : " + Dog.count);

        Dog.ShowAnimalType();
	}	
}
