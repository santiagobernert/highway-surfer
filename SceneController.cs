using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
    Score score;

    public void Play(){
        SceneManager.LoadScene("Scenes/Principal");
    }

    private void Start() {
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    public void Back(){
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void Pause(){
        score.paused = true;
        Time.timeScale = 0f;
        SceneManager.LoadScene("Scenes/Pause", LoadSceneMode.Additive);
    }

    public void Resume(){
        SceneManager.UnloadSceneAsync("Scenes/Pause");
        score.paused = false;
        Time.timeScale = 1f;
    }
}