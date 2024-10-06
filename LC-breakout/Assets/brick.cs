using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    public GameObject nextBrick;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            GameObject nextBrick = collision.gameObject.GetComponent<brick>().nextBrick;
            if (nextBrick != null)
            {
                Instantiate(nextBrick, collision.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}