using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualDPadTutorial : MonoBehaviour
{
    //from Unity Learn Tutorial
    public Text directionText;
    private Touch touch;

    private Vector2 touchStartPos,
        touchEndPos;

    private string direction;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchStartPos = touch.position;
            }
            else if(touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Ended)
            {
                touchEndPos = touch.position;

                float x = touchEndPos.x - touchStartPos.x;
                float y = touchEndPos.y - touchStartPos.y;

                if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
                {
                    direction = "Tapped";
                }
                
                else if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    direction = x > 0 ? "Right" : "Left";
                }
                else
                {
                    direction = y > 0 ? "Up" : "Down";
                }
            }
        }

        directionText.text = direction;
    }
}
