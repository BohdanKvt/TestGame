using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wintri : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        winscript.winn = "You win !";
    }
}
