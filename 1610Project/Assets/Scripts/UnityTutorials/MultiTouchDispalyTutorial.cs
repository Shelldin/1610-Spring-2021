using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTouchDispalyTutorial : MonoBehaviour
{
   //from Unity Learn Tutorial
   public Text multiTouchDisplay;

   private int maxTapCount = 0;
   private string multiTouchInfo;
   private Touch touch;

   void Update()
   {
       multiTouchInfo = string.Format("Max tap count: {0}\n", maxTapCount);

       if (Input.touchCount > 0)
       {
           for (int i = 0; i < Input.touchCount; i++)
           {
               touch = Input.GetTouch(i);

               multiTouchInfo +=
                   string.Format("touch {0} - Position {1} - Tap Count: {2} - Finger ID: {3}\nRadious: {4} ({5}%)\n",
                       i, touch.position, touch.tapCount, touch.fingerId, touch.radius, ((touch.radius / (touch.radius +
                           touch.radiusVariance)) * 100f).ToString("F1"));
               if (touch.tapCount > maxTapCount)
               {
                   maxTapCount = touch.tapCount;
               }
           }
       }

       multiTouchDisplay.text = multiTouchInfo;
   }
}
