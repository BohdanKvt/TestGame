using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
 
  
    
        void OnTriggerEnter2D(Collider2D col)
     {
        if (col.gameObject.name == "Character")
        {
            HealthBar.bul2 = true;
             

        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Character")
        {
            HealthBar.bul2 = false;


        }
    }
}
