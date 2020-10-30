using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarEnemy4 : MonoBehaviour
{
    public static bool bul1 = false;
    public Transform bar;
    public float health = 1f;

    public float damage = 0f;
    public void Start()
    {
        bar = transform.Find("EnemyBar4");

    }

    void Update()
    {
        if (bul1 == true)
        {
            damage = 0.2f;
            SetSize(health);

        }
        else if (health < 0)
        {
            Destroy(GameObject.FindWithTag("enemy4"));

        }


    }
    public float getHealth()
    {
        return health;
    }
    public void SetSize(float sizeNormalized)
    {
        health = sizeNormalized - damage;
        bar.localScale = new Vector3(health, 1f);
        damage = 0f;
        bul1 = false;
    }
}
