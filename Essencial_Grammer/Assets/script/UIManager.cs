using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text playerStateText;

    public void OnPlayerDead()
    {
        playerStateText.text = "넌 죽었당!"; 
    }
}
