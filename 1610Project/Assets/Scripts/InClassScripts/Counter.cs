using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public IntData numberCount;
    public int value = 10;
    public Text counterText;

    private void Start()
    {
        counterText.text = numberCount.value.ToString();
    }

    private void OnTriggerEnter2D()
    {
        numberCount.value += value;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }
    
}
