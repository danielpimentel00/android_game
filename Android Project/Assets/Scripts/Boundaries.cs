using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectHeight;
    public static bool topLimit;
    public static bool bottomLimit;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        if(gameObject.transform.position.y + (objectHeight/2 - 0.37) > screenBounds.y)
        {
            topLimit = true;
            GameController.gameOver = true;
        }
        else if(gameObject.transform.position.y - (objectHeight / 2 - 0.37) < -screenBounds.y)
        {
            bottomLimit = true;
            GameController.gameOver = true;
        }
        else
        {
            topLimit = false;
            bottomLimit = false;
        }
    }
}
