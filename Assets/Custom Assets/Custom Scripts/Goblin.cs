using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseMonster
{
    /// <summary>
    /// <para>
    ///     �޼��� ������ ���� �޴µ� �������̽��� �޸� �߻� Ŭ������ ����� �� �� ����
    /// </para>
    /// </summary>
    public override void Attack ()
    {
        Debug.Log("�� ĳ���͸� �����ߴ� " + damage);
    }
}