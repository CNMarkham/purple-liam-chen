using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftpaddlescript : MonoBehaviour
{
    // Update is called once per frame
    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
    }
}
