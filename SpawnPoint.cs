using System;
using UnityEngine;
using System.Collections.Generic;

public class SpawnPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colission) {
        Debug.Log("spawn" + colission.name);
    }
}