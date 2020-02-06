using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
	public Rigidbody2D Rb;
	public float Force;

	//When applying a constant force it should be done in FixedUpdate, which works like Update but for the physics engine.
	private void FixedUpdate()
	{
		Vector2 moveVector = Vector2.zero;
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			moveVector.x = -Force;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			moveVector.x = Force;
		}

		Rb.AddForce(moveVector);
	}
}
