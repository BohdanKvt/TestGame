using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbutton : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        enemymoove1.bul = true;
    }
}

