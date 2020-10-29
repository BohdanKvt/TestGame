 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
	private Rigidbody2D rb;
	private bool isGrounded;
	public float dash = 3000f;
	//public bool DashTime = true;
 
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		isGrounded = true;
		rb.freezeRotation = true;
	}

	 
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(dash, 0), ForceMode2D.Force);
			StartCoroutine(LateCall());
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-dash, 0), ForceMode2D.Force);
			StartCoroutine(LateCall());
		}
	}
	IEnumerator LateCall()
	{
		yield return new WaitForSeconds(0.00f);
		GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;

		yield return new WaitForSeconds(0.00f);
		GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
	}
}