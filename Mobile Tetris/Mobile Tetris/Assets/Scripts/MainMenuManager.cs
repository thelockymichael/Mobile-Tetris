using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public Text hiscoreText;

    // Start is called before the first frame update
    void Start()
    {
       //PlayerPrefs.GetInt("HighScore");
        hiscoreText.text = "Hiscore : " + GameManager.HighScore.ToString();
       // HighScore.GetComponent<Text>().text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        settingsMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
