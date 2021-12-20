using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;

    [SerializeField] TextMeshProUGUI playerName;

    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
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
            //retry button appears
        }
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
        return;
    }
}
