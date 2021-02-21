using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDebugPractice : MonoBehaviour
{
    
    //from Brakeys Tutorial
    void Update()
    {
        
        for (int i = 0; i < Input.touchCount; i++)
        {
            //Touch touch = Input.GetTouch(i);
            //Vector3 touchPos = touch.position;
           // touchPos.z = 0f;
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPos, Color.green);
        }
    }
}
