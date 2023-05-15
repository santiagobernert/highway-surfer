using System;
using UnityEngine;
using System.Collections.Generic;

public class Fragmentos : MonoBehaviour
{
    float spawnPoint = -2F;
    float deadPoint = -150F;
    private GameObject self;
    private Transform t;

    private void Start() {
        self = GetComponent<GameObject>();
        t = GetComponent<Transform>();
    }

    private void FixedUpdate() {
        if (t.position.y == spawnPoint){
            Debug.Log("spawn desde frag");
            GetComponent<Spawner>().Spawn();
        }
        if (t.position.y == deadPoint){
            Destroy(self);  
        }
    }

}