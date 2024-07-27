using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Resume()
    { 
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Pause()
    { 
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}