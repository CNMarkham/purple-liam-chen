using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed;
    public float minsize;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        if (transform.localScale.x > minsize)
        {
            transform.localScale = transform.localScale * 0.5f;
            Instantiate(gameObject, transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
