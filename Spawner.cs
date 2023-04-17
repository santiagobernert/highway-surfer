using System;
using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
     private void Start() {
        Instantiate(prefab, transform.position, Quaternion.identity);
     }
}