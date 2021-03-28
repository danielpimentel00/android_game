using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        if(t % 60 < 10)
        {
            gameObject.GetComponent<Text>().text = minutes + ":0" + seconds;
        }
        else
        {
            gameObject.GetComponent<Text>().text = minutes + ":" + seconds;
        }
    }
}
