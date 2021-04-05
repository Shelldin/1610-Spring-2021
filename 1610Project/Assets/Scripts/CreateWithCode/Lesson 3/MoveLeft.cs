﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    
    public float speed = 30;
    private PlayerController3 playerControllerScript;
    private float leftBound = -20f;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed));

        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}