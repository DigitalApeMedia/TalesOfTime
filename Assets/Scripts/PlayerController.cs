using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

	public float m_speed = 10.0f;
	public float j_amount = 20.0f;

	public Vector3 boundary;

	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float moveX = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveX, 0.0f, 0.0f);
		rb.AddForce (movement * m_speed);

		if( Input.GetKeyDown(KeyCode.Space))
			{
				rb.AddForce(Vector3.up * j_amount);
			}


	}
}
