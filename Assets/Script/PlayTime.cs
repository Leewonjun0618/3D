using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    float Score;
    Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        ScoreBoard = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Score += Time.deltaTime;
        ScoreBoard.text = "PlayTime : " + Score.ToString("0");
    }
}
