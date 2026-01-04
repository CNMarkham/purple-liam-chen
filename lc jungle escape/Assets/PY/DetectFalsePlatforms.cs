using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    private bool hit;
    public LayerMask layer = 1<< 8;
    void Update()
    {
        hit = Physics.Raycast(gameObject.transform.position, transform.forward, 0.15f, layer);
        Debug.DrawRay(gameObject.transform.position, transform.forward * 2, Color.blue);

        if (hit == true)
        {
            Debug.LogWarning("ground is unstable");
        } else
        {
            Debug.Log("ground is stable");
        }
    }
}
