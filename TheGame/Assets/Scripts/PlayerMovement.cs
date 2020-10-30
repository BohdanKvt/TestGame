using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 600;
    public float jumpforce = 300;
    public Rigidbody2D rb;
    private bool isgrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isgrounded = true;
    }

    void Update()
    {
        float xDisplacement;

            xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            rb.AddForce(new Vector2(0, jumpforce));
            isgrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isgrounded = true;

    }
}
