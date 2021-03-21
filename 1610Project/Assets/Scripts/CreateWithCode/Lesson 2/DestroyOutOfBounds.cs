using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float boundry = 30f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z>50)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -boundry)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
        
    }
}
