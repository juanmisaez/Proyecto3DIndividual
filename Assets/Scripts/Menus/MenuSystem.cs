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
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel1"); // escena del primer nivel
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // escena del menú de inicio
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    public void Instructions()
    {

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
        Time.timeScale = 1f;
        IsPaused(gameIsPaused);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // escena actual
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    public void NextLevel()
    {
        gameIsPaused = false;
        Time.timeScale = 1f;
        IsPaused(gameIsPaused);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // siguiente escena
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    void GameOver()
    {
        menuGameOverUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        IsOver(gameIsPaused);
    }

    void Win()
    {
        menuWinUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        IsOver(gameIsPaused);
    }

    public void Credits()
    {
        gameIsPaused = false;
        IsPaused(gameIsPaused);
        SceneManager.LoadScene("Credits");
        WriteNumSoldierSystem.ClearList();
        GC.Collect();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    void OnEnable()
    {
        InputSystemKeyboard.Paused += Menu;
        FinishSystem.PlayerWin += Win;
        FinishSystem.PlayerDead += GameOver;
    }
    void OnDisable()
    {
        InputSystemKeyboard.Paused -= Menu;
        FinishSystem.PlayerWin -= Win;
        FinishSystem.PlayerDead -= GameOver;
    }
}