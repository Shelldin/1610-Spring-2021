using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int numberCount,
        value = 10;
    public Text counterText;

    private void OnTriggerEnter2D()
    {
        numberCount += value;
        counterText.text = numberCount.ToString();
        gameObject.SetActive(false);
    }
    
}
