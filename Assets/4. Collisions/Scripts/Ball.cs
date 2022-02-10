using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Update()
    {
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(-2,3,0);
            transform.eulerAngles = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(0, 0);
            rb.angularVelocity = 0;
        }
    }
}
