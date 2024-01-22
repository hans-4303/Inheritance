using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     �̹� BaseRotator�� ���� ������Ʈ ��ް�
///     Update �޼��� ��� �� Rotate �޼��� ȣ���� ������
/// </para>
/// </summary>
public class ZRotator : BaseRotator
{
    protected override void Rotate ()
    {
        // base.Rotate (); �θ� �޼��带 ����ϸ鼭 �۵�
        this.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}

