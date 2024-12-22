using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : movement
{
    private bool occupied(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1.5f, obstaclelayer);
       return hit.collider != null;
    }

    protected void setDirection(Vector2 newdDirection)
    {
        if (!occupied(newdDirection))
        {
            direction = newdDirection;
            nextdirection = Vector2.zero;
        }
        else
        {
            nextdirection = newdDirection;
        }
    }

    void Update()
    {
        
    }
}
