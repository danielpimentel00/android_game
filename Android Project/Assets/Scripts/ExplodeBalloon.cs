using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBalloon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
            SoundManager.PlaySound("explosion_08");

            if (gameObject.tag == "blueballoon")
                HeliumController.heliumLevel += 10;
            else
                HeliumController.heliumLevel += 1;
        }
    }
}
