using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] bool start = false;
    float currTime;

    void Start()
    {
        
    }

    void Update()
    {
        if (start == true)
        {
            currTime = currTime + 1 * Time.deltaTime;
            Debug.Log(currTime.ToString("0.00"));
        }
    }
    public void StartTimer()
    {
        start = true;
    }
    public void StopTimer()
    {
        start = false;
    }
}
