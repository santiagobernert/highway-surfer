using System;
using UnityEngine;
using System.Collections.Generic;

public class Background : MonoBehaviour
{
    
    [SerializeField] float speed = 0.04F;
    public float start = 33.84f;
    public float end = -8.66f;
    private Transform t;

    private void Start(){
        t = GetComponent<Transform>();
    }

    private void Update() {
        t.position = new Vector2(t.position.x, t.position.y - speed);
        if (t.position.y <= end){
            t.position = new Vector3(t.position.x, start); 
        }
    }
}