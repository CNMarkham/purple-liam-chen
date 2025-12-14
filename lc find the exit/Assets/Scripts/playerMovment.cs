using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        float vertiacl = Input.GetAxis("Vertical");
        Vector3 destination = new Vector3(horizontal, 0, vertiacl);
        GetComponent<Rigidbody>().velocity = destination * speed;
    }
}
