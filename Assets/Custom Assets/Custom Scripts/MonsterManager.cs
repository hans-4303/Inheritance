using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    /// <summary>
    /// <para>
    ///     ���� �Ŵ����� ����� Get ���۸� ����, Set ������ ��� �� ����� ����
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
