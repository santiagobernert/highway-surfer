using System;
using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public List<GameObject> fragments;

     private void Start() {
        fragments.Add(prefab);
     }

      private void OnTriggerEnter2D(Collider2D other) {
         if (other.CompareTag("FragmentCollider")){
            Spawn();
         }
         
      }

     public void Spawn(){
        Debug.Log("spawn");
        GameObject fr = Instantiate(fragments[0], new Vector3(29.37f, 20.73f, 0), Quaternion.identity) as GameObject;
        fr.tag = "FragmentCollider";
        fragments.RemoveAt(0);
        fragments.Add(prefab);
     }
}