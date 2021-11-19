using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;
    [SerializeField] Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        if (TimerStatic.Timer != 0) { timer += TimerStatic.Timer; }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime % 60;
        timerText.text = "Time : " + Mathf.Round(timer);
    }
}
