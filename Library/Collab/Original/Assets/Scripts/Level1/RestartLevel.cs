using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
     [SerializeField]
    KeyCode keyRestart;
	
	void Update ()
    {
        if (Input.GetKey(keyRestart) || GameObject.Find("Player").transform.position.y < -70)
            //GameObject.Find("PauseMenu").SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
