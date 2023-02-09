using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
	public Rigidbody2D rb;
	public float force;

	private void Start()
	{
		rb.AddForce(new Vector2(force, 0f));
	}

	private void Update()
	{
		if( transform.position.y < -10f)
		{
			Destroy(gameObject);
		}
	}
}
