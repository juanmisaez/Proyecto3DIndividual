using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class MenuSystem : MonoBehaviour
{
    public static event Action<bool> IsPaused = delegate { }; // Al Inputsystem
    public static event Action<bool> IsOver = delegate { }; // Al Inputsystem

    public GameObject menuPauseUI;
    public GameObject menuWinUI;
    public GameObject menuGameOverUI;

    public static bool gameIsPaused = false;

    void Menu()
    {
        if (gameIsPaused == true)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene("Game"); // la escena del juego
    }

    public void LoadMenu()
    {
        //SceneManager.LoadScene("MainMenu"); // la escena del menú de inicio
    }

    public void Pause()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        IsPaused(gameIsPaused);
    }

    public void Resume()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        IsPaused(gameIsPaused);
    }

    public void Retry()
    {
        gameIsPaused = false;
        IsPaused(gameIsPaused);
        //SceneManager.LoadScene("Game"); // nombre de la escena actual
    }

    public void NextLevel()
    {
        //gameIsPaused = false;
        //IsPaused(gameIsPaused);
        //SceneManager.LoadScene("Game"); // nombre de siguiente escena
    }

    public void GameOver()
    {
        menuGameOverUI.SetActive(true);
        gameIsPaused = true;
        IsOver(gameIsPaused);
    }

    public void Win()
    {
        menuWinUI.SetActive(true);
        gameIsPaused = true;
        IsOver(gameIsPaused);
    }

    public void Credits()
    {
        gameIsPaused = false;
        IsPaused(gameIsPaused);
        //SceneManager.LoadScene("Credits"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void OnEnable()
    {
        InputSystemKeyboard.Paused += Menu;
    }
    void OnDisable()
    {
        InputSystemKeyboard.Paused -= Menu;
    }
}