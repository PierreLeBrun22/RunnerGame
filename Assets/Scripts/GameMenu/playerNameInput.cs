using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerNameInput : MonoBehaviour
{
    [SerializeField]
    public Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setName() {
        if(playerName.text.Length == 0) {
            PlayerPrefs.SetString("name", "Runner Anonyme");
        }
        else {
            PlayerPrefs.SetString("name", playerName.text);
        }
        SceneManager.LoadScene("Level1");
    }
}
