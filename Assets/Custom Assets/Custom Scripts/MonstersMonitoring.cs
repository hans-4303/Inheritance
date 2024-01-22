using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersMonitoring : MonoBehaviour
{

    public List<BaseMonster> monsters;

    void Start()
    {
        foreach (var monster in monsters)
        {
            Debug.Log(monster.gameObject.name);
        }
    }
}