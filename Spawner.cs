using System;
using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public List<GameObject> fragments;

     private void Start() {
        Instantiate(prefab, transform.position, Quaternion.identity);
     }

     public void Spawn(){
        Debug.Log("spawn");
        Instantiate(fragments[0], transform.position, Quaternion.identity);
        fragments.RemoveAt(0);
        fragments.Add(prefab);
     }
}