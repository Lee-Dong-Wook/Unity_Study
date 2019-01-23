using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {

    private void Start()
    {


        Container<string> container1 = new Container<string>();
        container1.message = new string[3];

        container1.message[0] = "I'm ";
        container1.message[1] = "studying ";
        container1.message[2] = "Unity ";

        for(int i = 0; i<3; i++)
        {
            Debug.Log("message is " + container1.message[i]);
        }

        Container<int> container2 = new Container<int>();
        container2.message = new int[3];

        container2.message[0] = 1;
        container2.message[1] = 2;
        container2.message[2] = 3;

        for (int i = 0; i < 3; i++)
        {
            Debug.Log("message is " + container2.message[i]);
        }
    }
}
public class Container<MyType>
{
    public MyType[] message;
}
