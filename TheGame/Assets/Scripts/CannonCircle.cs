using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CannonCircle : MonoBehaviour
{
    [Header("Ball")]
    public GameObject myBalls;
    public float shootdegree=15;

    [Header("Rotation Stuff")]
    public float startDegree = 60;
    public float stopDegree = 0;
    public float steps;
    public float step = -2;
    public float delay = 0.15f;
    private float timer;
    [HideInInspector]
    public bool pause;
    
    void Start()
    {
        timer = 0;
        steps = 0;
       pause = false;
    }

    void Update()
    {
        

         if (!pause)
         {
            timer += Time.deltaTime;

            if (timer > delay)
            {
                timer = 0;
                Rotate();

                if (Mathf.Abs(steps) > shootdegree)
                {
                    
                        Shoot();
                    
                }
            }
         }
        
        
    }

    void Shoot() {
            steps = 0;
        
        pause = true;
        Instantiate(myBalls, transform.position, transform.rotation);
    }

    void Rotate() {
        transform.Rotate(new Vector3(0, 0, step));

        if (transform.rotation.eulerAngles.z > startDegree || 
              transform.rotation.eulerAngles.z < stopDegree) {
            step *= -1;

        }

        steps += step;
    }

    
}
