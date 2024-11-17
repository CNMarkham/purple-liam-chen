using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWrap : MonoBehaviour
{
    private Vector2 screenmin;
    private Vector2 screenmax;

    void Start()
    {
        screenmin = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        screenmax = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
    }
}
