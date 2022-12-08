using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public string sceneName = "TitleScreen";
    public BirdScript bird;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if(bird.birdIsAlive == true)
        {
            playerScore += scoreToAdd;
            scoreText.text = "Score: " + playerScore.ToString();
        }
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void changeScene()
    {
        // Check if the scene exists
        if (SceneManager.GetSceneByName(sceneName) != null)
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
