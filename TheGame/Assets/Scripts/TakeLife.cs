using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeLife : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerStats.PlayerLives -= 1;
       // UnityEngine.Debug.Log(PlayerStats.PlayerLives);
    }
}
