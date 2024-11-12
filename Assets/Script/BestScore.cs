using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    int bestScore; 
    public Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
        ScoreBoard = GetComponent<Text>();
        ScoreBoard.text = $"BestScore : {bestScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
