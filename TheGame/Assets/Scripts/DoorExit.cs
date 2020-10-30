using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExit : MonoBehaviour
{
    private PlayerStats info;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (PlayerStats.hasKey == true)
        {
            SceneManager.LoadScene("Level2");
        }
        else {
            PlayerStats.FindKey();
        }
    }
}

