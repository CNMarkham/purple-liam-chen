using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour
{
    public float speed;
    public GameObject bulletprefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab, transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }
}
