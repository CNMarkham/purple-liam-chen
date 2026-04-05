using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    public GameObject[] hearts;
    private int lives = 6;
    public GameObject background;

    void Start()
    {
        
    }

    public void HurtPlayer()
    {
        lives -= 1;
        hearts[lives].SetActive(false);
        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
        Debug.Log(lives);
    }

    public void HealPlayer()
    {
        if (lives < 6)
        {
            hearts[lives].SetActive(true);
            lives += 1;
        }
        Debug.Log(lives);
    }

    void Update()
    {
        
    }
}
