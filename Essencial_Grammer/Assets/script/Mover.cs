using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    Vector3 movePosition = new Vector3(5, 5, 5);

    private void Start()
    {
        //transform.position = transform.position + movePosition;

        //transform.Translate(movePosition,Space.World);

        //transform.Translate(movePosition, Space.Self);
    }
}
