using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float jumpForce = 10f;
    public float gravityModifier = 1f;
    public bool grounded;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
          playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          grounded = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        grounded = true;
    }
}
