using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onlyfall : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 velocity = rb.velocity;
        velocity.y = Mathf.Min(velocity.y, 0);
        rb.velocity = velocity;
    }
}
