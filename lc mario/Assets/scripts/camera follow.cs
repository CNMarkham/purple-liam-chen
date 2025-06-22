using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null && target.position.x > transform.position.x)
        {
            transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        }
    }
}
