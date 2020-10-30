using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removeballs : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            Destroy(col.gameObject);
        }
    }
}
