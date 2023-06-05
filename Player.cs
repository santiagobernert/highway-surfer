using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{   
    Score score;
    Rigidbody2D rb;

    public void OnCollisionEnter2D(Collision2D colission) {
        if(score.scoreValue > score.highscore){
            score.highscore = (int)score.scoreValue;
            score.highscoreText.text = ""+score.highscore;
            PlayerPrefs.SetInt("highscore", score.highscore);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("Score").GetComponent<Score>();
        // sm = GetComponent<SceneManager>()
    }
    // Update is called once per frame
}
