using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 jumpForce;
    public float rotationForce;
    public float tiltForce;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           
        }
    }

    private void FixedUpdate()
    {
        
    }
}
