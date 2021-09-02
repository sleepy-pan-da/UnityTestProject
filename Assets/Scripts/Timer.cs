using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float timerDuration;
    [SerializeField]
    private UnityEvent OnTimeOut;
    [SerializeField]
    private bool isOneShot;
    private float timeRemaining;
    private bool timerIsRunning = false;


    void Start()
    {
        SetUpTimer();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                OnTimeOut.Invoke();
            }
        }
        else
        {
            if (!isOneShot)
            {
                SetUpTimer();
            }
        }
    }

    private void SetUpTimer()
    {
        timerIsRunning = true;
        timeRemaining = timerDuration;
    }
}
