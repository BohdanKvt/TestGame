using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;

    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -1 * speed;
    }

    // Update is called once per frame
    void Update()
    {
       // rb.velocity = transform.right * -1 * speed;
    }

    private void OnCollision2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Destroy(collision.gameObject);
        }
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
#if UNITY_EDITOR

     private void DoValidate() {
                 rb.velocity = transform.right * -1 * speed;
              }
           
#endif
}
