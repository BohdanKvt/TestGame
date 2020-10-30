using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifesScript : MonoBehaviour
{
    Text text;
    public static int lifes = 2;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = " Lifes: " + lifes.ToString();
        if (lifes < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            lifes += 2;
            scriptmove.speed = 1500;
           // Destroy(GameObject.FindWithTag("Player"));
        }
    }
}
