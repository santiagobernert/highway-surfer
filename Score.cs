using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreValue;
    public bool paused;
    public Text score;
    public Text highscoreText;
    public int highscore;
    public float scoreMultiplier = 0.8f;

    void Start() {
        scoreValue = 0;
        highscoreText.text = "" + PlayerPrefs.GetInt("highscore", highscore);
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
        scoreValue += Time.fixedTime/100 * scoreMultiplier;  
        
    }
}