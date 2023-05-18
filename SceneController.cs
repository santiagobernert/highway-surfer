using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class SceneController : MonoBehaviour 
{
    public void Play(){
        SceneManager.LoadScene("Scenes/Principal");
    }

    public void Back(){
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void Pause(){
        SceneManager.LoadScene("Scenes/Pause", LoadSceneMode.Additive);
    }

    public void Resume(){
        EditorSceneManager.CloseScene(SceneManager.GetSceneByName("Pause"), false);
    }
}