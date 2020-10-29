
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class enemymoove1 : MonoBehaviour
{
	public float speed = 5;
	public static bool bul = false;
	public bool MoveRight;
	private bool isGrounded;
	private Rigidbody2D rb;
	public void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		isGrounded = true;
		rb.freezeRotation = true;

	}

	// Use this for initialization

	void Update()
	{

		if (bul == true)
		{
			speed = 16;
			if (MoveRight)
			{

				transform.Translate(2 * Time.deltaTime * speed, 0, 0);

				transform.localScale = new Vector2(1, 1);

			}

			else
			{

				transform.Translate(-2 * Time.deltaTime * speed, 0, 0);

				transform.localScale = new Vector2(-1, 1);

			}
		}
		else
		{
			if (MoveRight)
			{

				transform.Translate(2 * Time.deltaTime * speed, 0, 0);

				transform.localScale = new Vector2(1, 1);

			}

			else
			{

				transform.Translate(-2 * Time.deltaTime * speed, 0, 0);

				transform.localScale = new Vector2(-1, 1);

			}
		}

	}

	void OnTriggerEnter2D(Collider2D trig)

	{

		if (trig.gameObject.CompareTag("turn"))
		{



			if (MoveRight)
			{

				MoveRight = false;

			}

			else
			{

				MoveRight = true;

			}

		}

	}
}



