using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("changeScore")]
    public void changeScore(int addScore)
    {
        playerScore += addScore;
        scoreText.text = playerScore.ToString();
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
}
