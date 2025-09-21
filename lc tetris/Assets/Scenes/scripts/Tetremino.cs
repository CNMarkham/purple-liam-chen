using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetremino : MonoBehaviour
{
    private float previousTime;
    public float fallTime;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right;
        }

        if ((Time.time - previousTime) >= fallTime)
        {
            transform.position = transform.position + Vector3.down;
            previousTime = Time.time;
        }

    }
}
