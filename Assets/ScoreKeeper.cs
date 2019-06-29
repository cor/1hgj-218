using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        if (playerIsAlive)
        {
            score++;
            UpdateScoreText();
        }
    }

    public void UpdateScoreText()
    {
        scoreText.text = "SCORE: " + score;
    }

    public void PlayerHasDied()
    {
        playerIsAlive = false;
    }
}
