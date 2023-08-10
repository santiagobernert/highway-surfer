using UnityEngine;
using System.Collections.Generic;
using static UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    public bool first = false;
    public bool truck = false;
    [SerializeField] List<Sprite> sprites;
    private SpriteRenderer sr;
    private Transform t;
    // -4.3  -2.55  -0.7
    

    private void Start() {
        t = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        if (truck == false){
            sr.sprite = Instantiate(sprites[Random.Range(0, sprites.Count)]) as Sprite;
        }
    }
}