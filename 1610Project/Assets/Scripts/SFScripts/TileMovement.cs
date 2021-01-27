using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//from GamesPlusJames Tutorial
public class TileMovement : MonoBehaviour
{

    public float movementSpeed = 5f;
    public Transform movementPoint;
    
    void Start()
    {
        movementPoint.parent = null;
    }

    void Update()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, movementPoint.position, movementSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movementPoint.position) <=.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            { 
                movementPoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f,0f);
            }

            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            { 
                movementPoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"),0f);
            }  
        }
        
        
    }
}
