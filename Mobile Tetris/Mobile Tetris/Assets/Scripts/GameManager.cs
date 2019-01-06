using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject MusicManager;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    // Start is called before the first frame update
    public void PauseGame()
    {
        MusicManager.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        MusicManager.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GoToSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("mainMenu");
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    void Start()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
