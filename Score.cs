using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreValue;
    public bool paused;
    public float time;
    public float startTime;
    public Text score;
    public Text highscoreText;
    public int highscore;
    public float scoreMultiplier = 1.2f;

    void Start() {
        PlayerPrefs.SetInt("highscore", 0);
        scoreValue = 0;
        highscoreText.text = "" + PlayerPrefs.GetInt("highscore", highscore);
        startTime = Time.time;
    }

    void Update() {
        score = GetComponent<Text>();  
        if (paused == false){
            if ((int)scoreValue < 1000){
                score.text = "00" + (int)scoreValue;
            } else{
                score.text = ""+(int)scoreValue;
            }
        }
        time = Time.time - startTime;
        scoreValue = time * scoreMultiplier;  
        
    }
}