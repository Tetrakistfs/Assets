using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {
        // if (PlayerPrefs.GetInt("HighScore") < playerScore)
        // {
        // }
    }

    [ContextMenu("changeScore")]
    public void changeScore(int addScore)
    {
        playerScore += addScore;
        scoreText.text = playerScore.ToString();
        if (playerScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        Debug.Log("Restarting the Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void setHighScore()
    {

    }
}
