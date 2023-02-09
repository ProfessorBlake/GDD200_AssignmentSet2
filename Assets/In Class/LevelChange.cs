using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
	public int LevelIndex;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log( $"Changing Level {LevelIndex}" );
		SceneManager.LoadScene(LevelIndex);
	}
}
