using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("HelloUnity");  
    }

    IEnumerator HelloUnity()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Hello Unity");
        }
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine("HelloUnity");
        }
    }
}

