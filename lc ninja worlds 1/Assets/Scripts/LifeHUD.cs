using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;

    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }

    public void HurtPlayer()
    {
        Debug.Log("Ouch!");
    }

    void Update()
    {
        
    }
}
