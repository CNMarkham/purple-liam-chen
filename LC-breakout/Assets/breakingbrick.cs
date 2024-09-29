using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class breakingbrick : MonoBehaviour
{
    public TMP_Text scoretext;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            score++;
            Debug.Log(score);
            scoretext.text = score.ToString();
            Destroy(collision.gameObject);

        }
    }
}
