using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{

	private void Update()
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-0.1f, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, 0.1f, 0f);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(0.1f, 0f, 0f);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, -0.1f, 0f);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Hit " + collision.gameObject.name);
	}
}
