using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }
}
