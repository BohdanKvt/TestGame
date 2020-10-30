using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
    {
     
    public static bool bul1 = false;
    public static bool bul2 = false;
    public Transform bar;
        public float health1 = 1f;
        public float health2 = 1f;
          
    public float damage = 0f;
   
   
    public void Start()
        {
            bar = transform.Find("Bar");
            

    }

        void Update() {
        if (bul1 == true && health1 > 0.1f)
        {

            damage = 0.2f;
            SetSize(health1);

        }
        else if (bul1 == true)
        {
            damage = 0.2f;
            SetSize(health2);
            LifesScript.lifes -= 1;
        }
        else if (bul2 == true && health1 > 0.1f)
        {
            damage = 0.0005f;
            SetSize(health1);

        }

        else if (bul2 == true)
        {
            damage = 0.0005f;
            SetSize(health2);
            LifesScript.lifes -= 1;
        }
         


    }
   
    public void SetSize(float sizeNormalized)
        {
        health1 = sizeNormalized - damage;
            bar.localScale = new Vector3(health1, 1f);
        damage = 0f;
        bul1 = false;
        }

    public void SetSize2(float sizeNormalized)
    {
       // yield return new WaitForSeconds(0.5f);
        health1 = sizeNormalized - damage;
        bar.localScale = new Vector3(health1, 1f);
        damage = 0f;
        bul1 = false;
    }



}
