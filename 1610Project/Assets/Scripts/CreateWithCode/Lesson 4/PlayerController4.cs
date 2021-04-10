using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    public float speed = 5f;

    private float powerUpStrength = 15;

    private Rigidbody playerRb;
    public GameObject focalPoint;
    public GameObject powerUpIndicatorObj;

    public bool hasPowerUp = false;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPointGameObject");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        
        playerRb.AddForce(focalPoint.transform.forward * (forwardInput * speed * Time.deltaTime));
        powerUpIndicatorObj.transform.position = transform.position + new Vector3(0, -.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUP"))
        {
            Destroy(other.gameObject);
            hasPowerUp = true;
            powerUpIndicatorObj.SetActive(true);
            StartCoroutine(PowerUpCountdownRoutine());
        }
    }

    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicatorObj.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;
            enemyRb.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
