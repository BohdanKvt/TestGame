using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
 
public class scriptmove : MonoBehaviour
{

    public static float speed = 2000;
    public float jumpForce = 600;
    private Rigidbody2D rb;
    private bool isGrounded;
    public float dash = 5000f;
    bool isHitted = false;
     
    SpriteRenderer sr;
    Color defaultColor;
    // public GameObject bullPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
        rb.freezeRotation = true;
        sr = GetComponent<SpriteRenderer>();
        defaultColor = sr.color;
    }
    public static void SetSpeed(float s)
    {

        speed += s;
    }
    public static float GetSpeed()
    {

        return speed;
    }

    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed += 2000;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed -= 2000;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(dash, 0), ForceMode2D.Force);
            StartCoroutine(LateCall());
            rb.freezeRotation = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-dash, 0), ForceMode2D.Force);
            StartCoroutine(LateCall());
            rb.freezeRotation = true;
        }
        /*

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }*/

    }
   /*void Shoot()
    {
        Instantiate(bullPrefab, transform.position, transform.rotation);
    }*/

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    { if (other.gameObject.CompareTag("damage"))
        {
            if (!isHitted)
            {
                isHitted = true;

                StartCoroutine("SwitchColor");
            }
        }
        if (other.gameObject.CompareTag("damage2"))
        {
            if (!isHitted)
            {
                isHitted = true;

                StartCoroutine("SwitchColor2");
            }
        }
    }


    IEnumerator SwitchColor()
    {
        sr.color = new Color(1f, 0.5f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        sr.color = defaultColor;
        isHitted = false;
    }
    IEnumerator SwitchColor2()
    {
        sr.color = new Color(1f, 0.5f, 0.5f);
        yield return new WaitForSeconds(5f);
        sr.color = defaultColor;
        isHitted = false;
    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(0.00f);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;

        yield return new WaitForSeconds(0.00f);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        rb.freezeRotation = true;
    }

}
