using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D),typeof(Collider2D))]
public class Balll : MonoBehaviour { 
    public float speed = 5;
    public Rigidbody2D rb;

    void Start() 
    { 
        rb.velocity = transform.right * speed;

    }

   private void onCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

#if UNITY_EDITOR
    private void OnValidate(){
     rb.velocity = transform.right * speed;
    }
#endif
}
