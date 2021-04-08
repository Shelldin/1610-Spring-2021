using System.Collections;
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
        enemyRb.AddForce((player.transform.position - transform.position).normalized * (speed * Time.deltaTime));
    }
}
