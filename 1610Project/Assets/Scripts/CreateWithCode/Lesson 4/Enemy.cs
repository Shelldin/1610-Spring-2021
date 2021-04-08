﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 3f;

    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Sphere");
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        
        enemyRb.AddForce( lookDirection * (speed * Time.deltaTime));
    }
}
