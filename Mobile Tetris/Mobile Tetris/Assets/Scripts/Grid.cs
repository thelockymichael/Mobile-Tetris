using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    //public static OnScreenNotification instance;
    //public static GameObject scoreText;
    public static int Score;
    public static Text gameOverText;

    private IEnumerator coroutine;
    // The Grid itself
    public static int w = 10;
    public static int h = 20;
    public static Transform[,] grid = new Transform[w, h];

    public static Vector2 roundVec2(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x),
                           Mathf.Round(v.y));
    }

    public static bool insideBorder(Vector2 pos)
    {
        return ((int)pos.x >= 0 &&
                (int)pos.x < w &&
                (int)pos.y >= 0);
    }

    public static void deleteRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            Score = Score + 10;
            Debug.Log("decreaseRow" + Score);
            SetCountText();
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }

    public static void decreaseRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] != null)
            {

                // Move one towards bottom
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;

                // Update Block position
                grid[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    public static void decreaseRowsAbove(int y)
    {
        for (int i = y; i < h; ++i)
            decreaseRow(i);

    }

    public static bool isRowFull(int y)
    {
        for (int x = 0; x < w; ++x)
            if (grid[x, y] == null)

                return false;
        return true;
    }

    public static void deleteFullRows()
    {
        for (int y = 0; y < h; ++y)
        {
            if (isRowFull(y))
            {
                deleteRow(y);
                decreaseRowsAbove(y + 1);
                --y;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
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

    public static void GameOver()
    {
        GameObject gameOverText = GameObject.Find("/Canvas/gameOverText");
        gameOverText.GetComponent<Text>().text = "Game Over";
       
     // StartCoroutine("GameOverDelay");
    }

    void Awake()
    {
       //gameOverText = this;
    }

    public static IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
