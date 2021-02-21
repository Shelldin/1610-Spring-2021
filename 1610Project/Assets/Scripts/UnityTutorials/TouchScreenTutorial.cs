using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchScreenTutorial : MonoBehaviour
{
    //from Unity Learn Tutorial
    public Text phaseDisplayText;
    private Touch touch;
    private float touchEndTime;
    private float timeDispaly = .5f;
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                phaseDisplayText.text = touch.phase.ToString();
                touchEndTime = Time.time;
            }
            else if(Time.time - touchEndTime > timeDispaly)
            {
                phaseDisplayText.text = touch.phase.ToString();
                touchEndTime = Time.time;
            }
        }
        else if (Time.time - touchEndTime>timeDispaly)
        {
            phaseDisplayText.text = "";
        }
    }
}
