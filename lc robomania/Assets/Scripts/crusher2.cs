using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crusher2 : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }
}
