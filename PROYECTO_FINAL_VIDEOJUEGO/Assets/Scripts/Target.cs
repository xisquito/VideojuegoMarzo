using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{

    public bool gameOver;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;


    public GameObject gameOverPanel;
    public GameObject menuPanel;

    private int score;
    public int missCounter;
    public int totalMisses = 3;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void UpdateLives()
    {
        livesText.text = $"Lives: {totalMisses - missCounter}";
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        menuPanel.SetActive(false);
    }
}
