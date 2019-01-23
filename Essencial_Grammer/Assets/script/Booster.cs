using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour {

    public void HealthBoost(Character target)
    {
        Debug.Log(target.playerName + "의 체력이 강화됬다!!!");
        target.hp += 10;
    }

    public void shieldBoost(Character target)
    {
        Debug.Log(target.playerName + "의 방어력이 증가했다!!");
        target.defense += 50;
    }

    public void DamageBoost(Character target)
    {
        Debug.Log(target.playerName + "의 공격력이 증가했다!!");
        target.damage += 10;
    }

    private void Awake()
    {
        Character player = FindObjectOfType<Character>();

        player.playerBoost += HealthBoost;
        player.playerBoost += shieldBoost;
        player.playerBoost += DamageBoost;
    }
}
