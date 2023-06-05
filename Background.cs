using System;
using UnityEngine;
using System.Collections.Generic;

public class Background : MonoBehaviour
{
    public float start = -5;
    public float end = 10;
    private Transform t;

    private void Awake(){
        t = GetComponent<Transform>();
    }

    private void Update() {
        if (t.position.y >= end){
            t.position = new Vector3(t.position.x, start); 
        }
    }
}