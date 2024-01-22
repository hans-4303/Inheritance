using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     부모 클래스
/// </para>
/// </summary>
public class Animal
{
    public string name;
    public float weight;
    public int year;

    public void Print()
    {
        Debug.Log(name + " " +  weight + " " + year);
    }

    /// <summary>
    /// <para>
    ///     Animal 클래스 안에서만 도는 함수
    /// </para>
    /// </summary>
    /// <returns></returns>
    private float CalcSpeed ()
    {
        return 100.0f / ( weight * year );
    }

    /// <summary>
    /// <para>
    ///     자식 클래스가 접근할 수 있지만 부모 클래스의 반환 값만 받아감
    /// </para>
    /// <para>
    ///     protected: 자식 클래스는 부모 클래스 메서드를 가져갈 수 있지만
    ///     연관 없는 클래스는 가져갈 수 없음
    /// </para>
    /// </summary>
    protected float GetSpeed()
    {
        return CalcSpeed();
    }
}

/// <summary>
/// <para>
///     Animal 기반으로 만든 Dog 클래스
/// </para>
/// <para>
///     미리 만들어둔 클래스 위에서 새로운 클래스를 만듦.
/// </para>
/// <para>
///     샌드박스 패턴 : 부모 클래스는 기능을 명세하고
///     자식 클래스는 기능을 조합해서 사용
/// </para>
/// </summary>
public class Dog: Animal
{
    /// <summary>
    /// <para>
    ///     자식 클래스만의 새로운 메서드를 만들되
    ///     부모 클래스 메서드와 필드 사용할 수 있었음
    ///     (물론 접근 권한이 널널해서지만)
    /// </para>
    /// </summary>
    public void Hunt()
    {
        float speed = GetSpeed();
        Debug.Log(speed + ": 속도");

        weight += 10.0f;
    }
    
    // CalcSpeed(); 접근 불가
}

public class Cat: Animal
{
    public void Stealth()
    {
        Debug.Log("숨었다");
    }
}