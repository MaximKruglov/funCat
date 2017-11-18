﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour {
	Rigidbody2D myBody;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal") * speed;
		float vertical = Input.GetAxis ("Vertical") * speed;
		myBody.AddForce (new Vector2 (horizontal, vertical));

	}

	void OnTriggerEnter2D( Collider2D other)
	{

		if (other.tag == "gem") {
			Destroy (other.gameObject);

		}
	}
}
