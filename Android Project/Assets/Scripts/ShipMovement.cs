using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float moveSpeed = 0.12f;
    private float topLimit = 4.2f;
    private float bottomLimit = -4.3f;

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

            if(touchPos.y > 0 && touchPos.x > 1 && gameObject.transform.position.y < topLimit)
            {
                //move up
                transform.Translate(0, moveSpeed, 0);
            }
            else if(touchPos.y < 0 && touchPos.x > 1 && gameObject.transform.position.y > bottomLimit)
            {
                //move down
                transform.Translate(0, -moveSpeed, 0);
            }
        }
    }
}
