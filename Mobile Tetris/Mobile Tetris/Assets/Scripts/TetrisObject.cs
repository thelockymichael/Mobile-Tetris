using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class TetrisObject : MonoBehaviour
{
    /*
    float lastFall = 0f;

    void Start()
    {

    }

    void Update()
    {

        var InputDevice = InputManager.ActiveDevice;
        // Action1
        // LeftStick
        // Input.GetAxisRaw()
        if (InputDevice.DPadLeft.WasPressed)
        {
            transform.position += new Vector3(-1, 0, 0);
            if (IsValidGridPosition())
            {
                UpdateMatrixGrid();
            }
            else
            {
                transform.position += new Vector3(1, 0, 0);

            }

        }
        else if (InputDevice.DPadRight.WasPressed)
        {
            transform.position += new Vector3(1, 0, 0);
            if (IsValidGridPosition())
            {
                UpdateMatrixGrid();
            }
            else
            {
                transform.position += new Vector3(-1, 0, 0);

            }
        }
        else if (InputDevice.DPadUp.WasPressed)
        {
            transform.Rotate(new Vector3(0, 0, -90));

            if (IsValidGridPosition())
            {
                UpdateMatrixGrid();
            }
            else
            {
                transform.Rotate (new Vector3(0, 0, 90));

            }
        }
        else if (InputDevice.DPadDown.WasPressed || Time.time - lastFall >= 1)
    
        {
            transform.position += new Vector3(0, -1, 0);

            if (IsValidGridPosition())
            {
                UpdateMatrixGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                MatrixGrid.DeleteWholeRows();
                FindObjectOfType<Spawner>().SpawnRandom();
                enabled = false;
            }
            lastFall = Time.time;
        }
    }


    bool IsValidGridPosition()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = MatrixGrid.RoundVector(child.position);

            if (!MatrixGrid.InInsideBorder(v))
                return false;

            if (MatrixGrid.grid[(int)v.x, (int)v.y] != null && MatrixGrid.grid[(int)v.x, (int)v.y].parent != transform)
                return false;
           
        }
        return true;
    }

    void UpdateMatrixGrid()
    {
        for (int y = 0; y < MatrixGrid.column; ++y)
        {
            for (int x = 0; x < MatrixGrid.row; ++x)
            {
                if (MatrixGrid.grid[x, y] != null)
                {
                    if (MatrixGrid.grid[x, y].parent == transform)
                    {
                        MatrixGrid.grid[x, y] = null;
                    }
                }
            }
        }

        foreach (Transform child in transform)
        {
            Vector2 v = MatrixGrid.RoundVector(child.position);
            MatrixGrid.grid[(int)v.x, (int)v.y] = child;
        }
    }*/
}
