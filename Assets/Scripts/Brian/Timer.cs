using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] bool start = false;
    [SerializeField] string levelName;
    [SerializeField] Text TimerObj;
    float highscore = 0;
    float currTime;
    void Start()
    {
        highscore = PlayerPrefs.GetFloat(levelName);
    }

    void Update()
    {
        if (start == true)
        {
            currTime = currTime + 1 * Time.deltaTime;
            TimerObj.text = "Time: " + currTime.ToString("0.00") + " --- Highscore: " + highscore.ToString("0.00");
        }
    }
    public void PauseTimer()
    {
        start = !start;
    }
    public void ResetTimer(bool Paused)
    {
        start = !Paused;
        currTime = 0;
        TimerObj.text = "Time: " + currTime.ToString("0.00") + " --- Highscore: " + highscore.ToString("0.00");
    }
    public void FinishedLevel()
    {
        start = false;
        if (currTime > highscore)
        {
            Debug.Log("New Highscore: " + currTime);
            highscore = currTime;
            PlayerPrefs.SetFloat(levelName, highscore);
        }
        else
        {
            Debug.Log("No New Highscore");
        }
        PlayerPrefs.SetFloat("TempTime", currTime);
        PlayerPrefs.SetString("lastLevel", levelName);
        PlayerPrefs.SetInt("finishedLevel", 1);
        PlayerPrefs.SetString("finishedScene", SceneManager.GetActiveScene().name);
        currTime = 0;
        TimerObj.text = "Time: " + currTime.ToString("0.00") + " --- Highscore: " + highscore.ToString("0.00");
        SceneManager.LoadScene("FinishScreen");
    }
    public void FailedLevel()
    {
        start = false;
        PlayerPrefs.SetFloat("TempTime", currTime);
        PlayerPrefs.SetString("lastLevel", levelName);
        PlayerPrefs.SetString("finishedScene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("finishedLevel", 0);
        SceneManager.LoadScene("FinishScreen");
    }
}
