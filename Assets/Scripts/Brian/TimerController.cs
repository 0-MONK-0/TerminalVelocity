using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    //THIS IS MORE TEMPORARY
    public bool restart;
    public bool pauseOnRestart = true;
    public bool pauseOrResume;
    public bool finishLevel;
    public GameObject timerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (restart == true)
        {
            restart = false;
            timerObj.GetComponent<Timer>().ResetTimer(pauseOnRestart);
        }

        if (pauseOrResume == true)
        {
            pauseOrResume = false;
            timerObj.GetComponent<Timer>().PauseTimer();
        }

        if (finishLevel == true)
        {
            finishLevel = false;
            timerObj.GetComponent<Timer>().FinishedLevel();
        }
    }
}
