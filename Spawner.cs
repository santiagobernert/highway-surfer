using System;
using UnityEngine;
using System.Collections.Generic;
using static UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;

      private void OnTriggerEnter2D(Collider2D other) {
         if (other.CompareTag("FragmentCollider")){
            Spawn();
         }
      }

     public void Spawn(){
        Debug.Log("spawn");
        GameObject fr = Instantiate(prefabs[Range(0, prefabs.Count)], new Vector3(29.37f, 29.73f, 0), Quaternion.identity) as GameObject;
        fr.tag = "FragmentCollider";
     }
}