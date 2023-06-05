using System;
using UnityEngine;
using System.Collections.Generic;

public class PowerUps : MonoBehaviour
{
    [SerializeField] string name;
    private string powerup;
    public Score score;

    private void OnTriggerEnter2D(Collider2D colission) {
        switch (name)
        {
            case "Wheel":
                powerup = "Wheel";
                break;
            case "Coin":
                powerup = "Coin";
                break;
            case "Rocket":
                powerup = "Rocket";
                score.scoreMultiplier = 16;
                break;
            case "Star":
                powerup = "Star";
                break;
            default:
                Debug.Log("power up");
                break;
        }
    }
}