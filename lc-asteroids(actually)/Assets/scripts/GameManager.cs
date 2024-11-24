using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockprefab;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-7, 7), Random.Range(-7, 7), 0f);
            Instantiate(rockprefab, randomPosition, Quaternion.identity);
        }
    }
}
