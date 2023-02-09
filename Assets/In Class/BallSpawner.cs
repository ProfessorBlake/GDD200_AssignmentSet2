using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public GameObject BallPrefab;
	public List<GameObject> ballList = new List<GameObject>();

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject newBall = Instantiate(BallPrefab, transform.position, Quaternion.identity);
			ballList.Add(newBall);
		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			for (int i = 0; i < ballList.Count; i++)
			{
				Destroy(ballList[i]);
			}
			ballList.Clear();
		}
	}
}