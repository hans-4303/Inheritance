using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCalculator : MonoBehaviour
{
    public PointManager pointManager;

    /// <summary>
    /// <para>
    ///     ���͸� �� ������ �Ѱܵ� Set���� ó���ϰ�
    ///     Get�� ���� ������ ��ȯ
    /// </para>
    /// </summary>
    private void Start ()
    {
        pointManager.Point = 100; // Set ����
        Debug.Log(pointManager.Point); // Get ����

        pointManager.Point = -100;
        Debug.Log(pointManager.Point);

        pointManager.Point = 10000;
        Debug.Log(pointManager.Point);
    }
}
