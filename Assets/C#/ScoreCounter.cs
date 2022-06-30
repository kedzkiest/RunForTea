using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;

    public Text scoreText;
    public Text finalScore;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.enabled = true;
        finalScore.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeCounter.isTimeUp)
        {
            scoreText.enabled = false;
            finalScore.enabled = true;
        }
        
        scoreText.text = "Score: " + score;
        finalScore.text = "Your score: " + score;
    }
}
