using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D colission) {
        Debug.Log("choque");
    }
}