using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGeneration : MonoBehaviour
{
    public GameObject rain;
    public GameObject rainGenerator;

    int x;
    Vector3 offset;
    float timer;
    
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        //if timer exceeds 2.5 seconds, instantiate a raindrop at a random x value on screen
        if(timer >= 2.5){
            Debug.Log("Test");
            x = Random.Range(6, -6);
            offset = new Vector3 (x, 0, 0);

            Instantiate(rain, transform.position + offset, transform.rotation); 

            timer = 0;
        } 
    }
}
