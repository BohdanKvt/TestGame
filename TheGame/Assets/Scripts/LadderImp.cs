using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderImp : MonoBehaviour
{

	public float speed = 4;
	public Rigidbody2D rb;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player" && Input.GetKey(KeyCode.W))
		{
			rb.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);

		}
		else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
		{
			rb.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);

		}
		else {
			rb.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}



	}



}
