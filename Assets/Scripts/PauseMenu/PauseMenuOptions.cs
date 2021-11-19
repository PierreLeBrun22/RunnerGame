
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour
{
   	public void continuer(){
        GameObject.Find("PauseMenu").SetActive(false);
		Time.timeScale = 1f;
	}

    public void goToMenu() {
        SceneManager.LoadScene("GameMenu");
        TimerStatic.Timer = 0;
        Time.timeScale = 1f;
    }

    public void quitGame(){
		Application.Quit();
	}
}
