using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelScript : MonoBehaviour
{
    Text text;
    public static int level;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = " LEVEL -> " + level.ToString();
        
    }
}
