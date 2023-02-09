using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Power;

    private bool started;

    void Start()
    {
        Rb.gravityScale = 0;
    }

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space) && started == false)
		{
            Rb.gravityScale = 1;
            Rb.AddForce(new Vector2(0, 1) * Power);
            started = true;
		}
    }
}
