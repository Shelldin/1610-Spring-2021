using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContollerTwo : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;

    public float xBoundaryRange = 10f;

    private Vector3 leftBoundaryVector3;
    private Vector3 rightBoundaryVector3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xBoundaryRange)
        {
            leftBoundaryVector3.Set(-xBoundaryRange, transform.position.y, transform.position.z);
            transform.position = leftBoundaryVector3;
        }

        if (transform.position.x > xBoundaryRange)
        {
            rightBoundaryVector3.Set(xBoundaryRange, transform.position.y, transform.position.z);
            transform.position = rightBoundaryVector3;
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
    }
}
