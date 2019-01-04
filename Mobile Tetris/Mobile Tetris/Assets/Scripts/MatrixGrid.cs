using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixGrid
{
    public static int column = 20;
    public static int row = 10;

    public Transform[,] grid = new Transform[row, column];

    public static Vector2 RoundVector (Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }

    public static bool InInsideBorder(Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < row && (int)pos.y >=0);
    }
    

    }

