using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject MusicManager;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public GameObject gameOverMenu;

    public static string scoreString;

    static public GameManager instance;
    public static GameManager Instance { get { return instance; } }

    // Points
    public static int Score;

    public static int HighScore;

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
        Score = 0;
        GameObject newHighScoreText = GameObject.Find("/Canvas/newHighScoreText");
        newHighScoreText.GetComponent<Text>().text = "";

        GameObject HighScore = GameObject.Find("/Canvas/highScoreText");
        HighScore.GetComponent<Text>().text = "Hiscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        gameOverMenu.SetActive(false);
       
        SetCountText();
        GameObject gameOverText = GameObject.Find("/Canvas/gameOverText");
        gameOverText.GetComponent<Text>().text = "";

    }

    public static void SetCountText()
    {
        GameObject scoreText = GameObject.Find("/Canvas/scoreText");
        scoreText.GetComponent<Text>().text = "Score : " + Score.ToString();
        Debug.Log(scoreText);
        /* if (count >= 12)
         {
             winText.text = "You Win!";
         }*/
    }

    public static void AddPoints()
    {
        Score = Score + 10;
        Debug.Log("decreaseRow" + Score);
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void GameOver()
    {
        GameObject gameOverText = GameObject.Find("/Canvas/gameOverText");
        gameOverText.GetComponent<Text>().text = "Game Over";
        if (Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);

            GameObject HighScore = GameObject.Find("/Canvas/highScoreText");
            HighScore.GetComponent<Text>().text = "Hiscore: " + Score.ToString();
            //  HighScore.GetComponent<Text>().text = scoreString;
            Debug.Log("Congratulations on new Score");
            GameObject newHighScoreText = GameObject.Find("/Canvas/newHighScoreText");
            newHighScoreText.GetComponent<Text>().text = "New High \n Score!";
        }
        DoCoroutine();
    }

    /*
    public static void GameOver()
    {
        GameObject gameOverText = GameObject.Find("/Canvas/gameOverText");
        gameOverText.GetComponent<Text>().text = "Game Over";
        if (Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);

            GameObject HighScore = GameObject.Find("/Canvas/highScoreText");
            HighScore.GetComponent<Text>().text = "Hiscore: " + Score.ToString();
          //  HighScore.GetComponent<Text>().text = scoreString;
            Debug.Log("Congratulations on new Score");
            GameObject newHighScoreText = GameObject.Find("/Canvas/newHighScoreText");
            newHighScoreText.GetComponent<Text>().text = "New High \n Score!";
        }
        DoCoroutine();
    }*/

    public void SetHighScore()
    {

    }

    void Awake()
    {
        instance = this;
        /*
        if (PlayerPrefs.HasKey("CurrentSkin"))
        {
      
            Score = PlayerPrefs.GetInt("Score");
    
        }
        else
        {
            Save();
        }*/
    }

    /*public void Save()
    {
        PlayerPrefs.SetInt("Score", Score);
    }*/

    static public void DoCoroutine()
    {
        instance.StartCoroutine("GameOverDelay"); //this will launch the coroutine on our instance
    }

    IEnumerator GameOverDelay()
    {
        Debug.Log("GAME OVER DELAY WORKS!");
        yield return new WaitForSeconds(1);
        gameOverMenu.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
  