using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.position.y > transform.position.y + 0.4f)
            {
                GetComponent<Animator>().SetTrigger("death");
                GetComponent<CircleCollider2D>().enabled = false;
                GetComponent<enemymovement>().enabled = false;
                Rigidbody2D playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
                playerRB.velocity = new Vector2(playerRB.velocity.x/4, 10);
                Destroy(gameObject, 0.5f);
            }
            else
            {
                collision.gameObject.GetComponent<playerbehaviour>().Hit();
            }
        }
    }
}
