using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     이미 BaseRotator를 통해 컴포넌트 취급과
///     Update 메서드 사용 및 Rotate 메서드 호출이 결정됨
/// </para>
/// </summary>
public class ZRotator : BaseRotator
{
    protected override void Rotate ()
    {
        // base.Rotate (); 부모 메서드를 사용하면서 작동
        this.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}

