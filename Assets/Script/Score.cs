using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    Text ScoreBoard;
    int BestScore;
    // Start is called before the first frame update
    void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore");
        score = 0;
        ScoreBoard = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard.text = "Score : " + score.ToString();
        if (score > BestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
}
