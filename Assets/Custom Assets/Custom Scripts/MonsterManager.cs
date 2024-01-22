using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     몬스터 매니저를 만들되 Get 동작만 만듦, Set 동작이 없어서 값 덮어쓰기 방지
    /// </para>
    /// </summary>
    public int Count
    {
        get
        {
            Monster[] monsters = FindObjectsOfType<Monster>();
            return monsters.Length;
        }
    }
}
