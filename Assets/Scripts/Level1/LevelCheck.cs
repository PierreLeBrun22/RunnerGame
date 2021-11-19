using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCheck : MonoBehaviour
{
    void Update()
    {
         if(GameObject.Find("Player").transform.position.x >= 795) {
             GameObject thePlayer = GameObject.Find("Player");
             Timer timerScript = thePlayer.GetComponent<Timer>();
             TimerStatic.Timer = timerScript.timer;
             SceneManager.LoadScene("Level2");
         }
    }
}
