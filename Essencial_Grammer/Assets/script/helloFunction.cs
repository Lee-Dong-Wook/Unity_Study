using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float sizeOfCircle = 30f;

        float radius = getRadius(sizeOfCircle);

        Debug.Log("원의 사이즈 : " + sizeOfCircle + "원의 반지름 : " + radius);
	}
	
    float getRadius(float size)
    {
        float pi = 3.14f;

        float tmp = size / pi;

        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
	

}
