using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.gameOver)
        {
            gameObject.SetActive(false);
            SoundManager.PlaySound("explosion_02");
        }
    }
}
