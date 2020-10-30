using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedscr : MonoBehaviour
{

    Text text;
    public static float speedd = scriptmove.GetSpeed();
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = " SPEED: " + scriptmove.GetSpeed();
            
    }
}
