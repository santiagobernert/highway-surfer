using UnityEngine;
using System.Collections.Generic;
using static UnityEngine.Random;

public class PowerUps : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    string powerup;
    private SpriteRenderer sr;
    Score score;

    private void Start() {
        score = GameObject.Find("Score").GetComponent<Score>();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Instantiate(sprites[Random.Range(0, sprites.Count)]) as Sprite;
    }
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