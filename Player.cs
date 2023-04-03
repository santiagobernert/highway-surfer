using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    Rigidbody2D rb;
    [SerializeField] float speed = 0.05F;

    public void OnCollisionEnter2D(Collision2D colission) {
        Debug.Log("choque");
    }

    private void OnTriggerEnter2D(Collider2D colission) {
        Debug.Log("colissione con" + colission.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(Vector3.up*speed, ForceMode2D.Force);
    }

}
