using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messenger : MonoBehaviour {

    public delegate void Send(string receiver);

    Send onSend;

    private void Start()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += man => Debug.Log("Assasinate " + man);
        onSend += (string man) => { Debug.Log("Assasinate " + man); };
    }
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onSend("Raynor");
        }
    }

    void SendMail(string receiver)
    {
        Debug.Log("Mail sent to " + receiver);
    }

    void SendMoney(string receiver)
    {
        Debug.Log("Mail sent to " + receiver);
    }
}
