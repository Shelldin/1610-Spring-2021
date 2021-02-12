using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;

    private Vector2 xDirection,
        yDirection;

    public float speed = 3f,
        jumpForce = 300f;

    private void Update()
    {
        xDirection.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(xDirection, ForceMode2D.Force);
        

        if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            ballRigidbody2D.AddForce(yDirection,ForceMode2D.Force);
        }
    }
}
