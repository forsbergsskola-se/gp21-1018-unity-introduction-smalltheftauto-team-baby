using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    private int highscore = 0;


    private void Awake()
    {
        instance = this;
        
        //ScoreManager.instance.Addpoint();
        //  ^ add this to update ui
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        // TODO: A good start to implementing savegames, but not what was asked for.
        if(highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        
    }
}
