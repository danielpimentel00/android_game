using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GenerateBalloons : MonoBehaviour
{
    public Rigidbody2D[] balloons;
    public Transform balloonSpawner;

    private float[] spawnTime = {  1, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f };

    void Start()
    {
        StartCoroutine("CreateBalloon");
    }

    IEnumerator CreateBalloon()
    {
        int randomSpawn = Random.Range(0, 6);
        yield return new WaitForSeconds(spawnTime[randomSpawn]);

        while (true)
        {
            Rigidbody2D BalloonInstance;
            int randomNum = Random.Range(0, 7);

            BalloonInstance = Instantiate(balloons[randomNum], balloonSpawner.position, balloonSpawner.rotation) as Rigidbody2D;
            //BalloonInstance.AddForce(-balloonSpawner.right * 750f);

            randomSpawn = Random.Range(0, 6);
            yield return new WaitForSeconds(spawnTime[randomSpawn]);
        }

    }
}
