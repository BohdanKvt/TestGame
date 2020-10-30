using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject bullPrefab;
    public float delay = 1;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {


        //update the position

         timer += Time.deltaTime;
         if (timer > delay) {
             timer = 0;
             Shoot2();
         }
      /*  if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Shoot1();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot2();
        }*/
    }

    void Shoot1()
    {
        // Vector3 rotationVector = new Vector3(-30, -30, 0);
        Quaternion rotationn = Quaternion.Euler(0, 0, -180);
        Instantiate(bullPrefab, transform.position, rotationn);



    }
    void Shoot2()
    {
        // Vector3 rotationVector = new Vector3(-30, -30, 0);

        Instantiate(bullPrefab, transform.position, transform.rotation);



    }
}
