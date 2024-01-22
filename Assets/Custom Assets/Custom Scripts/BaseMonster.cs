using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     추상 클래스, 구현 및 명세가 섞여있음.
///     자식 클래스가 상속받아 구현해야 하며 추상 클래스가 인스턴스로 찍혀 나올 수 없음
/// </para>
/// </summary>
public abstract class BaseMonster : MonoBehaviour
{
    public float damage = 100.0f;

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    public abstract void Attack();
}