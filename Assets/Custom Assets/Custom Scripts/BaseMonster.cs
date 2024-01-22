using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     �߻� Ŭ����, ���� �� ���� ��������.
///     �ڽ� Ŭ������ ��ӹ޾� �����ؾ� �ϸ� �߻� Ŭ������ �ν��Ͻ��� ���� ���� �� ����
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