using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject PausePanel;
    public void ReplayGame()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button Click");
        SceneManager.LoadScene("Level00");
    }


    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button Click");
        SceneManager.LoadScene("Level00");
    }


    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().PlaySound("Button Click");
        SceneManager.LoadScene("Main");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        PausePanel.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Button Click");
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        PausePanel.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button Click");
        Time.timeScale = 1;
    }
}
