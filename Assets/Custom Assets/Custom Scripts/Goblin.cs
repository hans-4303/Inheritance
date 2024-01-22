using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseMonster
{
    /// <summary>
    /// <para>
    ///     메서드 구현을 강제 받는데 인터페이스와 달리 추상 클래스의 멤버도 쓸 수 있음
    /// </para>
    /// </summary>
    public override void Attack ()
    {
        Debug.Log("한 캐릭터를 공격했다 " + damage);
    }
}