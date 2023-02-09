using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;

    public void TakeDamage(int damage)
	{
		Health -= damage;
		Debug.Log(Health);
		if( Health <= 0)
		{
			Destroy(gameObject);
		}
	}
}
