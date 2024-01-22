using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCalculator : MonoBehaviour
{
    public PointManager pointManager;

    /// <summary>
    /// <para>
    ///     필터링 될 값들을 넘겨도 Set에서 처리하고
    ///     Get을 통해 간단히 반환
    /// </para>
    /// </summary>
    private void Start ()
    {
        pointManager.Point = 100; // Set 동작
        Debug.Log(pointManager.Point); // Get 동작

        pointManager.Point = -100;
        Debug.Log(pointManager.Point);

        pointManager.Point = 10000;
        Debug.Log(pointManager.Point);
    }
}
