using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalloon : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2);
    }
}
