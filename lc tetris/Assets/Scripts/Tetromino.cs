using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    private float previousTime;
    public float fallTime;
    public int width;
    public int height;
    public Vector3 rotationPoint;
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
            transform.position = transform.position + Vector3.left;
            if (!ValidMove())
            {
                transform.position = transform.position - Vector3.left;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right;
            if (!ValidMove())
            {
                transform.position = transform.position - Vector3.right;
            }
        }

        float tempTime = fallTime;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;
        }

        if ((Time.time - previousTime) >= tempTime)
        {
            transform.position = transform.position + Vector3.down;
            if (!ValidMove())
            {
                transform.position = transform.position - Vector3.down;
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
        }
        return true;
    }
}
