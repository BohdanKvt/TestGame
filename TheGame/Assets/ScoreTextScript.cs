using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = " Keys -> " + coinAmount.ToString();
        if (coinAmount > 3) {
            coinAmount = 0;
            levelScript.level += 1;
           scriptmove.SetSpeed(600);
            //scriptmove.jumpForce += 200;
        }
    }
}
