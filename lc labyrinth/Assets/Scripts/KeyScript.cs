using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject door;
    public Transform escape;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(door);
            other.GetComponent<MoveToGoal>().agent.destination = escape.position;
            Destroy(gameObject);
        }
    }
}
