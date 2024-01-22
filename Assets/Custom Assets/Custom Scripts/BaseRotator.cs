using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     ȸ���ϴ� ��� ������Ʈ���� ��ӹ޴� ������Ʈ�� ����
/// </para>
/// </summary>
public class BaseRotator : MonoBehaviour
{
    public float speed = 60.0f;

    private void Update ()
    {
        Rotate();
    }

    protected virtual void Rotate()
    {
        this.transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
