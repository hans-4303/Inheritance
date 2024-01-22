using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     회전하는 모든 오브젝트들이 상속받는 컴포넌트라 가정
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
