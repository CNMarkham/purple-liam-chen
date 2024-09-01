using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    public string playername;
    private ulong highestpop;
    private GameplayManager gamemanager;

    public TMP_Text nametext;
    public TMP_Text yeartext;
    public TMP_Text highestpoptext;


    // Start is called before the first frame update
    void Start()
    {
        nametext.text = "ruler: " + playername;

        gamemanager = GetComponent<GameplayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        yeartext.text = "year: " + gamemanager.year;

        if (gamemanager.population > highestpop)
        {
            highestpop = gamemanager.population;
            highestpoptext.text = "highest population: " + highestpop;
        }
    }
}
