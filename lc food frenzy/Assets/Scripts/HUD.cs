using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    public Level level;
    public TMP_Text remainingText;
    public TMP_Text remainingLabel;
    public TMP_Text targetText;
    public TMP_Text targetLabel;
    public TMP_Text scoreText;
    public Image starsImage;

    public Sprite[] stars;

    private int starIndex;
    private bool isGameOver;

    public static HUD instance;

    void Start()
    {
        if (!instance)
        {
            instance = this;
            UpdateStars();
        }
    }

    void Update()
    {
        
    }

    public void UpdateStars()
    {
        starsImage.sprite = stars[starIndex];
    }
}
