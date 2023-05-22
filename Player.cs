using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{   
    Rigidbody2D rb;

    public void OnCollisionEnter2D(Collision2D colission) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // sm = GetComponent<SceneManager>()
    }
    // Update is called once per frame
}
