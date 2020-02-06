using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
	public Rigidbody2D Rb;
	public float Force;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Rb.AddForce(new Vector2(0f, Force)); //Force is a vector2 (right/left, up/down).
			Debug.Log(Rb.velocity);
		}
	}
}
