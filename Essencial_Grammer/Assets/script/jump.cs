using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public Rigidbody rb;

    private void Start()
    {
        rb.AddForce(100,100,100);
    }
}
