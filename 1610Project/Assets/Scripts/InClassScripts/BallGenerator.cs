using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;
    private int number = 0;
    
    IEnumerator Start()
    {
        while (number < 10)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(ball);
            number++;
        }
    }
    
}
