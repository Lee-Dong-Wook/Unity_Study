using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldItem : MonoBehaviour, PlayerItem {

    public int goldAmount = 100;

    public void Use()
    {
        Debug.Log("골드를 얻었다.");

        Player player = FindObjectOfType<Player>();
        player.gold += goldAmount;

        gameObject.SetActive(false);
    }
}
