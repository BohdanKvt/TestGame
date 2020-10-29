using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coim : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ot)
    {
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
       
    }
}
