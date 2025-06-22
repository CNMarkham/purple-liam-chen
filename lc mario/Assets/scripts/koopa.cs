using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class koopa : MonoBehaviour
{
    private bool shelled;
    private bool shellmoving;
    public float shellspeed = 15;
    void Start()
    {
        shelled = false;
        shellmoving = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        if (collision.transform.position.y > transform.position.y + 0.04f)
        {
            if (shelled)
            {
                launch();
            }
            else
            {
                GetComponent<Animator>().SetTrigger("shell");
                GetComponent<enemymovement>().speed = 0;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                shelled = true;
            }

            Rigidbody2D playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
            playerRB.velocity = new Vector2(playerRB.velocity.x, 20);
        }
        else if (shelled && !shellmoving)
        {
            launch();
        }
        else
        {
            collision.gameObject.GetComponent<playerbehaviour>().hit();
        }
    }

    private void launch()
    {
        GetComponent<enemymovement>().speed = 15;
        GetComponent<Rigidbody2D>().velocity = Vector3.right * 15;
        shellmoving = true;
    }
}
