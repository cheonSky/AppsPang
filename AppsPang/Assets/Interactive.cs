using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public RectTransform _image;
    private Vector2 mousePosition1;
    private int check;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;

            if (Vector2.Distance(_image.position, mousePosition) < 50)
            {
                mousePosition1 = mousePosition;
                check = 1;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (check == 1)
            {
                Vector2 mousePosition2 = Input.mousePosition;
                Vector2 mouseMove = (mousePosition1 - mousePosition2);
                float X = Mathf.Abs(mouseMove.x);
                float Y = Mathf.Abs(mouseMove.y);

                if (mouseMove.y < 0 && X < Y)
                {
                    Debug.Log("Up");
                }
                else if (mouseMove.y > 0 && X < Y)
                {
                    Debug.Log("Down");
                }
                else if (mouseMove.x > 0 && X > Y)
                {
                    Debug.Log("Left");
                }
                else if (mouseMove.x < 0 && X > Y)
                {
                    Debug.Log("Right");
                }
            }

            check = 0;
        }
    }
}