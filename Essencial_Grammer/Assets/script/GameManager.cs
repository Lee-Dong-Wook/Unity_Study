using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

    public void OnPlayerDead()//UI스크립트의 동명함수와 전혀 다름
    {
        Invoke("Restart",2f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(0); //현재 씬 재시작 
    }	
}
