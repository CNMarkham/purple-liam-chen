using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockprefab;
    public Transform[] spawnpoints;
    void Start()
    {
        InvokeRepeating("spawnrocks", 0f, 60f);
    }
    private void spawnrocks()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 randomposition = spawnpoints[0].position;
            Instantiate(rockprefab, randomposition, Quaternion.identity);
        }
    }
}
