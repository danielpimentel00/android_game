using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float moveSpeed = 0.12f;

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveUpDown();
    }

    void MoveUpDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPos.y > 0 && touchPos.x > 1)
            {
                //move up
                transform.Translate(0, moveSpeed, 0);
            }
            else if(touchPos.y < 0 && touchPos.x > 1)
            {
                //move down
                transform.Translate(0, -moveSpeed, 0);
            }
        }
    }
}
