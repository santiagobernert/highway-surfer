using UnityEngine;
using System.Collections.Generic;
using static UnityEngine.Random;

public class PowerUps : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    string powerup;
    private SpriteRenderer sr;
    Score score;
    MovementAutomatic movementAutomatic;
    Player player;

    private void Start() {
        score = GameObject.Find("Score").GetComponent<Score>();
        // movementAutomatic = GameObject.Find("MovementAutomatic").GetComponent<MovementAutomatic>();
        // player = GameObject.Find("Player").GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Instantiate(sprites[Random.Range(0, sprites.Count)]) as Sprite;
    }
    private void OnCollisionEnter2D(Collider2D colission) {
        if(colission.gameObject.name.Contains("Player")){
           switch (sr.sprite.name)
            {
            case "burningwheel":
                powerup = "Wheel";
                // movementAutomatic._speed = 0.12f; 
                break;
            case "rocket":
                powerup = "Rocket";
                score.scoreMultiplier = 16;
                break;
            case "champagne":
                powerup = "Star";
                break;
            case "star":
                powerup = "Star";
                // player.isTrigger = true;
                break;
            default:
                Debug.Log("power up");
                break;
            } 
        }
        
    }
}