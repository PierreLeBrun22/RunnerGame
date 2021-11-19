using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    [SerializeField] Text scoreText;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] EndText endText;

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
        endText.showMe();
    }
}
