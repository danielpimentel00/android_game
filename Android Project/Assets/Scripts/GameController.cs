using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject HUDPanel;
    public GameObject pausePanel;
    public GameObject victoryPanel;
    public GameObject menuPanel;
    public GameObject ship;

    public static bool gameOver;
    public static bool won;

    void Start()
    {
        Menu();
    }

    void Update()
    {
        GameEnded();
        Victory();
    }

    private void GameEnded()
    {
        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            HUDPanel.SetActive(false);

            Time.timeScale = 0;
        }
    }

    private void Victory()
    {
        if(won)
        {
            victoryPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void Menu()
    {
        won = false;
        gameOver = false;

        HeliumController.heliumLevel = 30;

        ship.GetComponent<Transform>().position = new Vector3(6.63f, 0, 0);

        menuPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        HUDPanel.SetActive(false);
        pausePanel.SetActive(false);
        victoryPanel.SetActive(false);

        Time.timeScale = 0;

        DestroyInGameObjects();
    }

    public void Play()
    {
        menuPanel.SetActive(false);
        HUDPanel.SetActive(true);
        ship.SetActive(true);

        Time.timeScale = 1;

        won = false;
        gameOver = false;

        ship.GetComponent<Transform>().position = new Vector3(6.63f, 0, 0);

        Timer.startTime = Time.time;


    }

    public void Retry()
    {
        won = false;
        gameOver = false;

        Time.timeScale = 1;

        gameOverPanel.SetActive(false);
        HUDPanel.SetActive(true);
        victoryPanel.SetActive(false);
        ship.SetActive(true);

        ship.GetComponent<Transform>().position = new Vector3(6.63f, 0, 0);

        Timer.startTime = Time.time;

        HeliumController.heliumLevel = 30;

        DestroyInGameObjects();
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

    private void DestroyInGameObjects()
    {
        //Destroy ballons
        GameObject[] balloons = GameObject.FindGameObjectsWithTag("balloon");
        foreach (GameObject bal in balloons)
            GameObject.Destroy(bal);

        //Destroy blue ballons
        GameObject[] blueBalloons = GameObject.FindGameObjectsWithTag("blueballoon");
        foreach (GameObject bal in blueBalloons)
            GameObject.Destroy(bal);

        //Destroy projectiles
        GameObject[] projectiles = GameObject.FindGameObjectsWithTag("projectile");
        foreach (GameObject bul in projectiles)
            GameObject.Destroy(bul);
    }
}
