using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour 
{
    Score score;
    float startTime;
    float midTime;

    public void Play(){
        SceneManager.LoadScene("Scenes/Principal");
    }

    private void Start() {
        score = GameObject.Find("Score").GetComponent<Score>();
        startTime = GameObject.Find("Score").GetComponent<Score>().startTime;
    }

    public void Back(){
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void Pause(){
        score.paused = true;
        SceneManager.LoadScene("Scenes/Pause", LoadSceneMode.Additive);
        midTime = Time.time;
    }

    public void Resume(){
        SceneManager.UnloadSceneAsync("Scenes/Pause");
        score.paused = false;
        startTime = midTime;
    }
}