using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionBehaviour : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
