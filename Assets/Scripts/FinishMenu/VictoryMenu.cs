using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text timeText;

    private void Start() {
        nameText.text = "Runner : " + PlayerPrefs.GetString("name");
        timeText.text = "Temps : " + Mathf.Round(TimerStatic.Timer);
    }

    public void scoresButtonClick() {
        SceneManager.LoadScene("Scoreboard");
        TimerStatic.Timer = 0;
    }

    public void goToMenu() {
        SceneManager.LoadScene("GameMenu");
        TimerStatic.Timer = 0;
    }
}
