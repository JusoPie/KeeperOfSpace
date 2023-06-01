using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    int score = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text ="Score: " + score.ToString();
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void AddScore() 
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
