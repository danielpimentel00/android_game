using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeProjectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "balloon")
        {
            Destroy(gameObject);
        }
    }
}
