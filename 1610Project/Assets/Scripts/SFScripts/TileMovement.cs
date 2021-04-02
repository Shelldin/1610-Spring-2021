using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//from GamesPlusJames Tutorial
public class TileMovement : MonoBehaviour
{

    public float movementSpeed = 5f;
    public Transform movementPoint;

    private Vector3 movePositionV3 = new Vector3(0f, 0f,0f);
    
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
                movePositionV3.x = Input.GetAxisRaw("Horizontal");
                movePositionV3.y = 0f;
                movementPoint.position += movePositionV3;
            }

            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePositionV3.y = Input.GetAxisRaw("Vertical");
                movePositionV3.x = 0f;
                movementPoint.position += movePositionV3;
            }  
        }
        
        
    }
}
