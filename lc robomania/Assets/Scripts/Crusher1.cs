using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher1 : MonoBehaviour
{
    public float speed;

    /*private void FixedUpdate()
    {
        if (transform.position.x <= -8 || transform.position.x >= 8)
        {
            speed *= -1;
        }
        float newXPos = transform.position.x + speed * Time.deltaTime;
        float newYPos = transform.position.y;
        Vector2 newPos = new Vector2(newXPos, newYPos);
        transform.position = newPos;
    }*/

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }
}
