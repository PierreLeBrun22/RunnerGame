using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jouerButtonClick() {
        SceneManager.LoadScene("PlayerName");
    }

    public void scoresButtonClick() {
        SceneManager.LoadScene("Scoreboard");
    }

    public void goToMenu() {
        SceneManager.LoadScene("GameMenu");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
