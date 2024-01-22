using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>
///     �θ� Ŭ����
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
    ///     Animal Ŭ���� �ȿ����� ���� �Լ�
    /// </para>
    /// </summary>
    /// <returns></returns>
    private float CalcSpeed ()
    {
        return 100.0f / ( weight * year );
    }

    /// <summary>
    /// <para>
    ///     �ڽ� Ŭ������ ������ �� ������ �θ� Ŭ������ ��ȯ ���� �޾ư�
    /// </para>
    /// <para>
    ///     protected: �ڽ� Ŭ������ �θ� Ŭ���� �޼��带 ������ �� ������
    ///     ���� ���� Ŭ������ ������ �� ����
    /// </para>
    /// </summary>
    protected float GetSpeed()
    {
        return CalcSpeed();
    }
}

/// <summary>
/// <para>
///     Animal ������� ���� Dog Ŭ����
/// </para>
/// <para>
///     �̸� ������ Ŭ���� ������ ���ο� Ŭ������ ����.
/// </para>
/// <para>
///     ����ڽ� ���� : �θ� Ŭ������ ����� ���ϰ�
///     �ڽ� Ŭ������ ����� �����ؼ� ���
/// </para>
/// </summary>
public class Dog: Animal
{
    /// <summary>
    /// <para>
    ///     �ڽ� Ŭ�������� ���ο� �޼��带 �����
    ///     �θ� Ŭ���� �޼���� �ʵ� ����� �� �־���
    ///     (���� ���� ������ �γ��ؼ�����)
    /// </para>
    /// </summary>
    public void Hunt()
    {
        float speed = GetSpeed();
        Debug.Log(speed + ": �ӵ�");

        weight += 10.0f;
    }
    
    // CalcSpeed(); ���� �Ұ�
}

public class Cat: Animal
{
    public void Stealth()
    {
        Debug.Log("������");
    }
}