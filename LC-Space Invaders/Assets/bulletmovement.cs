using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}