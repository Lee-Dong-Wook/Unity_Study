using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotator : MonoBehaviour {

    public float speed = 60f;

    protected virtual void Rotate(){}

    private void Update()
    {
        Rotate();
    }
}
