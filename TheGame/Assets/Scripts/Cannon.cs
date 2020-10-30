using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private CannonCircle circle;
    
    void Start()
    {
        circle = GetComponentInParent<CannonCircle>();
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            circle.pause = false;
        }
    }
}
