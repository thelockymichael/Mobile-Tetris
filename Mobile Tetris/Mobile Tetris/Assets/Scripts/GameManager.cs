using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject settingsMenu;

    // Start is called before the first frame update
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
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
