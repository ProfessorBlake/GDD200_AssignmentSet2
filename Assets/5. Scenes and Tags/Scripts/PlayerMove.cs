using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
	public float WalkSpeed;

	private Vector3 startPosition;

	private void Start()
	{
		startPosition = transform.position;
	}

	private void Update()
	{
		Vector3 moveVector = Vector3.zero;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			moveVector.x = -WalkSpeed;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			moveVector.x = WalkSpeed;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			moveVector.y = WalkSpeed;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			moveVector.y = -WalkSpeed;
		}

		transform.position += moveVector;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Reset"))
		{
			transform.position = startPosition;
		}
		else if (collision.CompareTag("Goal"))
		{
			int sceneNumber = SceneManager.GetActiveScene().buildIndex;
			if (sceneNumber == 0)
			{
				SceneManager.LoadScene(1); //Remember this index is set in Build Settings -> Scenes.
			}
			else
			{
				SceneManager.LoadScene(0);
			}
		}
	}
}
