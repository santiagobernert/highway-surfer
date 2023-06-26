using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    Score score;
    Rigidbody2D rb;
    public Text coinText;
    int coins;

    public void OnCollisionEnter2D(Collision2D colission) {
        if(score.scoreValue > score.highscore){
            score.highscore = (int)score.scoreValue;
            score.highscoreText.text = ""+score.highscore;
            PlayerPrefs.SetInt("highscore", score.highscore);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnTriggerEnter2D(Collider2D colission){
        if(colission.gameObject.name.Contains("Coin")){
            coins++;
            PlayerPrefs.SetInt("coins", coins);
            Destroy(colission.gameObject);
            coinText.text = "" + coins;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = GameObject.Find("Score").GetComponent<Score>();
        coinText = GameObject.Find("CoinsText").GetComponent<Text>();
        coins = PlayerPrefs.GetInt("coins", 0);
        // sm = GetComponent<SceneManager>()
    }
    // Update is called once per frame
}
