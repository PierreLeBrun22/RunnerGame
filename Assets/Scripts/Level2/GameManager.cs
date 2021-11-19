using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        scoreText.text = "Score: "+score;
        // Increase the player's speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
        // end of the game
        if (score == 20)
        {
            EndGame();
        }
    }
    private void Awake(){
        inst = this;
    }

    void EndGame()
    {
        GameObject thePlayer = GameObject.Find("Player");
        Timer timerScript = thePlayer.GetComponent<Timer>();
        scoreManager.AddScore(new Score(PlayerPrefs.GetString("name"), Mathf.Round(timerScript.timer)));
        TimerStatic.Timer = timerScript.timer;
        SceneManager.LoadScene("FinishMenu");
    }
}
