using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brickPrefab;

    public float xspace;
    public float xoffset;

    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            Instantiate(brickPrefab, new Vector2(x * xspace + xoffset, 3), Quaternion.identity);
            Instantiate(brickPrefab, new Vector2(x * xspace + xoffset, 3.75f), Quaternion.identity);
            Instantiate(brickPrefab, new Vector2(x * xspace + xoffset, 4.5f), Quaternion.identity);
        }
    }
}
