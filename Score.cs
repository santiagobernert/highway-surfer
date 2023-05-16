using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreValue;
    public Text score;

    void Start() {
        scoreValue = 0;
    }

    void Update() {
        score = GetComponent<Text>();  
        if ((int)scoreValue < 1000){
            score.text = "00" + (int)scoreValue;
        } else{
            score.text = ""+(int)scoreValue;
        }
        
        scoreValue += Time.deltaTime * 8;  
    }
}