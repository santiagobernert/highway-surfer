using System;
using UnityEngine;
using System.Collections.Generic;

public class DeadPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colission) {
        Debug.Log("dead" + colission.name);
        Destroy(colission.gameObject);
    }
}