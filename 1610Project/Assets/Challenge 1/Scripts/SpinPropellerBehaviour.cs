using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerBehaviour : MonoBehaviour
{
    public GameObject propellerObj;
    public Vector3 rotateVector3;

    void FixedUpdate()
    {
        propellerObj.transform.Rotate(rotateVector3);
    }
}
