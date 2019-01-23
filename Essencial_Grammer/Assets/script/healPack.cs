using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPack : MonoBehaviour,PlayerItem {

    public int HealAmount = 10;

    public void Use()
    {
        Debug.Log("체력이 늘엇다.");

        Player player = FindObjectOfType<Player>();
        player.Hp += HealAmount;

        gameObject.SetActive(false);
    }
}
