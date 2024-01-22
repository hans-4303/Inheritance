using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ork : BaseMonster
{
    public override void Attack ()
    {
        Debug.Log("광역으로 공격했다 " + damage);
    }
}
