using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class movement : MonoBehaviour
{
    public float speed;
    public Vector2 initialDirection;
    public LayerMask obstacleLayer;

    protected Rigidbody2D rb;
    protected Vector2 direction;
    protected Vector2 nextDirection;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = initialDirection;
        nextDirection = Vector2.zero;
    }


    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(position + translation);
    }


    abstract protected void childUpdate();


    private bool occupied(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1.5f, obstacleLayer);
        return hit.collider != null;
    }


    protected void setDirection(Vector2 newdDirection)
    {
        if (!occupied(newdDirection))
        {
            direction = newdDirection;
            nextDirection = Vector2.zero;
        }
        else
        {
            nextDirection = newdDirection;
        }
    }


    void Update()
    {
        if (nextDirection != Vector2.zero)
        {
            setDirection(nextDirection);
        }
        childUpdate();
    }
}
