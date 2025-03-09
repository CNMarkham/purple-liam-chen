using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> availableDriections;

    void Start()
    {
        availableDriections = new List<Vector2>();

        checkAvailableDirection(Vector2.up);
        checkAvailableDirection(Vector2.down);
        checkAvailableDirection(Vector2.left);
        checkAvailableDirection(Vector2.right);
    }
    
    private void checkAvailableDirection(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1.5f, obstacleLayer);
        if (hit.collider == null)
        {
            availableDriections.Add(newDirection);
        }
    }
}
