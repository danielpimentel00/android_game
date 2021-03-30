using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeliumController : MonoBehaviour
{
    public static int heliumLevel;

    void Start()
    {
        heliumLevel = 30;

        StartCoroutine("DecreaseHeliumLevel");
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = heliumLevel.ToString();

        if (heliumLevel <= 0)
        {
            GameController.gameOver = true;
        }
        else if (heliumLevel >= 100)
        {
            GameController.won = true;
        }
    }

    IEnumerator DecreaseHeliumLevel()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);

            heliumLevel -= 5;
        }
    }
}
