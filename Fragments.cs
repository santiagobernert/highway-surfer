using System;
using UnityEngine;

public class Fragments : MonoBehaviour
{
    [SerializeField] List<GameObject> fragments;
    
    [SerializeField] float spawnPoint = 2F;
    [SerializeField] float deadPoint = -150F;

    private void Update() {
        if (fragments[0].position.y <= spawnPoint){
            fragments[1];
        }
        if (fragments[0].position.y <= deadPoint){
            fragments.remove(0);
        }
    }

}