using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
	public SpriteRenderer sprrend;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Pinball ball = collision.gameObject.GetComponent<Pinball>();
		if (ball != null)
		{
			sprrend.color = Color.red;
		}
	}
}
