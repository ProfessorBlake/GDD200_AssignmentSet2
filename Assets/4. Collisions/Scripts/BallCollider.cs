using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{ 
		Debug.Log(gameObject.name + " hit " + collision.gameObject.name);
	}
}
