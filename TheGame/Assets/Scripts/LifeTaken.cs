using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTaken : MonoBehaviour
{   
    void Update() { 
    if(PlayerStats.PlayerLives==1){
            Destroy(gameObject);
        }
    
    }
}
