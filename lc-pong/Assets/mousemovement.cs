using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightpaddlescript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        Vector2 tempposition = new Vector2(x, y);
        transform.position = tempposition;
    }
}
