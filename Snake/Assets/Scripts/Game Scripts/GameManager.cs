using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool paused = false;
    public bool endGame = false;
    public int score = 0;

    public GameObject pauseMenu;

    public Text scoreText;

    void Start()
    {
        score = 0;
        pauseMenu.SetActive(false);
    }

    void OnGUI()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (paused)
            {
                pauseMenu.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                paused = true;
                Time.timeScale = 0;
            }
        }
        if (endGame)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }

}
