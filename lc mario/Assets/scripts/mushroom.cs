using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            collision.gameObject.GetComponent<playerbehaviour>().grow();
            Destroy(gameObject, 1.28f);
        }
        else
        {
            return;
        }
    }
}
