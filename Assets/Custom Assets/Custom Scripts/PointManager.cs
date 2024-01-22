using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    private int point = 0;

    public int Point
    {
        get { return point; }
        set
        {
            if (value < 0) point = 0;
            else if (value > 9999) point = 9999;
            else point = value;
        }
    }
}
