using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public SpriteRenderer sprrend;

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")) * speed);
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        Enemy e = collision.gameObject.GetComponent<Enemy>();
		if (e != null)
		{
            e.TakeDamage(1);
        }
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        //if (collision.CompareTag("Fire"))
        //{
        //    // damage += 1;
        //    Destroy(collision.gameObject);
        //    Debug.Log(collision.gameObject.name);
        //}
	}
}
