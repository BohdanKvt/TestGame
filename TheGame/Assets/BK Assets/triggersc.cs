using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class triggersc : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Character")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
