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

        // left side
        if (x > screenmax.x + 2)
        {
            transform.position = new Vector2(screenmin.x - 1, y);
        }

        // right side
        if (x < screenmin.x - 2)
        {
            transform.position = new Vector2(screenmax.x + 1, y);
        }

        // top
        if (y > screenmax.y + 2)
        {
            transform.position = new Vector2(x, screenmin.y - 1);
        }

        // bottom
        if (y < screenmin.y - 2)
        {
            transform.position = new Vector2(x, screenmax.y + 1);
        }
    }
}
