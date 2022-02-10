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
		if(collision.tag == "Points")
        {
			collision.transform.position = new Vector3(Random.Range(-5f,5f), Random.Range(-5f, 5f), 0);
        }
		else if(collision.tag == "Damage")
        {
			transform.position = new Vector3(0, 0, 0);
        }
        else
        {
			Debug.Log("Not sure what you hit.");
        }
	}
}
