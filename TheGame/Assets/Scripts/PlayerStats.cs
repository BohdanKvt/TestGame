using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public static int PlayerLives=2;
    public static bool hasKey;
    public static bool trigger;
    public GameObject noKey;
    public GameObject findKey;
    public GameObject message;
    public BoxCollider2D key;
    
    void Start()
    {
        hasKey = false;
        trigger = false;
        noKey.SetActive(false);
        findKey.SetActive(false);

    }

   
    void Update()
    {
        if (PlayerLives == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        if (trigger == true) {
            noKey.SetActive(true);
            message.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.name == "Key") {
            hasKey = true;
            Destroy(col.gameObject);
            noKey.SetActive(false);
            findKey.SetActive(true);
            message.SetActive(false);
        }
        
    }

    public static void FindKey() {
        trigger = true;
    }
}
