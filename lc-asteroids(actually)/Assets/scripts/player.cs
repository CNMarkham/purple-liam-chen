using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float lookSpeed;
    public float moveSpeed;
    public float maxSpeed;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }
}
