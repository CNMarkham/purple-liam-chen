using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    [System.Serializable]
    public struct ButtonPlayerPrefs
    {
        public Image starsImage;
        public string playerPrefKey;
    }
    public ButtonPlayerPrefs[] buttons;

    public Sprite[] stars;

    void Start()
    {
        foreach (ButtonPlayerPrefs button in buttons)
        {
            int score = PlayerPrefs.GetInt(button.playerPrefKey, 0);
            button.starsImage.sprite = stars[score];
        }
    }

    void Update()
    {
        
    }

    public void LevelSelectButtonPressed(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
