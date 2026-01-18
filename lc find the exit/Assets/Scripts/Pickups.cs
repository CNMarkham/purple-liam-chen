using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public ParticleSystem Pickup;
    public GameObject Door;

    void Start()
    {
        Pickup.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            Debug.Log("trigger");
            Destroy(other.gameObject);
            Destroy(Door.gameObject);

            Pickup.Play();
        }
    }
}
