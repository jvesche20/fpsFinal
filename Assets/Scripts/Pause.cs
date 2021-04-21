﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject ui;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;

        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        LoadScene("Main Menu 1");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
