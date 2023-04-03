using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool Colission;

    public void OnCollisionEnter2D(Collision2D colission) {
        Debug.Log("choque");
    }

    private void OnTriggerEnter2D(Collider2D colission) {
        Debug.Log("colissione con" + colission.name);
    }
}