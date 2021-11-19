using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    [SerializeField] Text scoreText;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] EndText endText;
    public ScoreManager scoreManager;

    public void IncrementScore(){
        score++;
        scoreText.text = "SCORE: "+score;
        // Increase the player's speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
        // end of the game
        if (score == 10)
        {
            EndGame();
        }
    }
    private void Awake(){
        inst = this;
    }

    void EndGame()
    {
        scoreManager.AddScore(new Score(PlayerPrefs.GetString("name"), 10));
        endText.showMe();
    }
}
