using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbarrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerbehaviour>().Hit();
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
