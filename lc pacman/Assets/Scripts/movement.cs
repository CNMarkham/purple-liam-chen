using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class movement : MonoBehaviour
{
    public float speed;
    public Vector2 initialdirection;
    public LayerMask obstaclelayer;

    protected Rigidbody2D rb;
    protected Vector2 direction;
    protected Vector2 nextdirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = initialdirection;
        nextdirection = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        rb.MovePosition(position + translation);
    }
}
