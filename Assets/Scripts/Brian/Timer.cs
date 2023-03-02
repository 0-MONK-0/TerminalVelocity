using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] bool start = false;
    [SerializeField] int levelNumber;
    [SerializeField] Text TimerObj;
    float highscore = 0;
    float currTime;
    void Start()
    {
        
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
        }
        else
        {
            Debug.Log("No New Highscore");
        }

        currTime = 0;
        TimerObj.text = "Time: " + currTime.ToString("0.00") + " --- Highscore: " + highscore.ToString("0.00");
    }
}
