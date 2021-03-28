using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject HUDPanel;
    public GameObject pausePanel;
    public GameObject ship;

    public static bool gameOver;

    void Start()
    {
        gameOverPanel.SetActive(false);
        HUDPanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            HUDPanel.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void Retry()
    {
        gameOver = false;
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        HUDPanel.SetActive(true);
        ship.GetComponent<Transform>().position = new Vector3(6.63f, 0, 0);

        Timer.startTime = Time.time;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
