using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : BaseMonster {

    public override void Attack()
    {
        Debug.Log("광역 공격했다. 공격력 : " + damage * 100);
    }
}
