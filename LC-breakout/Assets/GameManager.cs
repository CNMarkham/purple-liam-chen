using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;

    public float xspace;
    public float xoffset;

    void Start()
    {
        for (int x = 0; x < 6; x++)
        {
            Instantiate(brickPrefab, new Vector2(x * xspace + xoffset, 2.5f), Quaternion.identity);
            Instantiate(brick1, new Vector2(x * xspace + xoffset, 3.25f), Quaternion.identity);
            Instantiate(brick2, new Vector2(x * xspace + xoffset, 4f), Quaternion.identity);
            Instantiate(brick3, new Vector2(x * xspace + xoffset, 4.75f), Quaternion.identity);
        }
    }
}
