﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public GameObject gameOverPanel;
    public Text timeScore;



    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        timeScore.text = Time.timeSinceLevelLoad.ToString("00");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public static void GameOver(bool dead)
    {
        if (dead)
        {
            instance.gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
