using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float time = 0;
    public bool isTimerOn = false;

    private ScoreData sd;
    void Awake()
    {
        //PlayerPrefs.SetString("scores", "{}");
        var json = PlayerPrefs.GetString("scores", "{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
    }

    void Update() {
        if(isTimerOn) {
            time += Time.deltaTime;
            //Debug.Log(time);
        }
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderBy(x => x.score);
    }

    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }

    private void OnDestroy()
    {
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("scores", json);
    }

    public void setTime() {
        isTimerOn = true;
    }
}























