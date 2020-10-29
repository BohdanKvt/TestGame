using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]

public class damage : MonoBehaviour
{
    
    public float speed = 30;
    public Rigidbody2D rb;
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -1 * speed;
    }
    private void OnTriggerEnter2D(Collider2D ot)
    {
        if (ot.gameObject.CompareTag("Player"))
        {
            HealthBar.bul1 = true;
            Destroy(gameObject);
        }
        else {
            Destroy(gameObject);
        }

        if (ot.gameObject.CompareTag("enemy1"))
        {
            HealthBarEnemy1.bul1 = true;
            Destroy(gameObject);
        }
        else if (ot.gameObject.CompareTag("enemy2")) {
            HealthBarEnemy2.bul1 = true;
            Destroy(gameObject);
        }
        else if (ot.gameObject.CompareTag("enemy3"))
        {
            HealthBarEnemy3.bul1 = true;
            Destroy(gameObject);
        }
        else if (ot.gameObject.CompareTag("enemy4"))
        {
            HealthBarEnemy4.bul1 = true;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
#if UNITY_EDITOR

     private void DoValidate() {
                 rb.velocity = transform.right * -1 * speed;
              }
           
#endif
}
