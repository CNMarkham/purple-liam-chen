using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    private float previousTime;
    public float fallTime;
    public static int width;
    public static int height;
    public Vector3 rotationPoint;
    public static Transform[,] grid = new Transform[width, height];
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 convertedPoint = transform.TransformPoint(rotationPoint);
            transform.RotateAround(convertedPoint, Vector3.forward, 90);
            if (!ValidMove())
            {
                transform.RotateAround(convertedPoint, Vector3.forward, -90);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
            if (!ValidMove())
            {
                transform.position -= Vector3.left;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
            if (!ValidMove())
            {
                transform.position -= Vector3.right;
            }
        }

        float tempTime = fallTime;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime /= 10;
        }

        if ((Time.time - previousTime) >= tempTime)
        {
            transform.position += Vector3.down;
            if (!ValidMove())
            {
                transform.position -= Vector3.down;
                this.enabled = false;
                AddToGrid();
                FindObjectOfType<Spawner>().SpawnTertomino();
            }
            previousTime = Time.time;
        }
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
            
            if (x < -4 || y < -2 || x >= width || y >= height)
            {
                return false;
            }

            if (grid[x, y] != null)
            {
                return false;
            }
        }
        return true;
    }

    public void AddToGrid()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);

            grid[x, y] = child;
        }
    }
}
