using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject enemies1;
    public GameObject enemies2;
    public GameObject enemies3;

    public float xspace;
    public float xoffset;

    void Start()
    {
        for (int x = 0; x < 6; x++)
        {
            Instantiate(enemies1, new Vector2(x * xspace + xoffset, 2.5f), Quaternion.identity);
            Instantiate(enemies2, new Vector2(x * xspace + xoffset, 3.25f), Quaternion.identity);
            Instantiate(enemies3, new Vector2(x * xspace + xoffset, 4f), Quaternion.identity);
        }
    }
}
