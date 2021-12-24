using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;

    [SerializeField] TextMeshProUGUI playerName;

    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;


    [SerializeField] TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = "Player: " + MainManager.playerName;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            GameOver();
        }
    }

    //ABSTRACTION
    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
        return;
    }

    public void GameOver()
    {
        //restart button appears
        restartButton.gameObject.SetActive(true);
        mainMenuButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        gameOver = true;
    }

    public void Restart()
    {
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        gameOver = false;
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        gameOver = false;
        SceneManager.LoadScene(0);
    }
}
