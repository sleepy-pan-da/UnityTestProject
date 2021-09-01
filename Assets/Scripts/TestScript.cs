using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyIntEvent : UnityEvent<int>
{
}

public class TestScript : MonoBehaviour
{

    [SerializeField]
    private GameObject cubePrefab;
    [SerializeField]
    private MyIntEvent TestEvent;
    private String MessageToPrint = "Sup boi";

    private int currentXCoodinate = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab, new Vector3(currentXCoodinate, 0, 0), Quaternion.identity);
            currentXCoodinate += 1;
            TestEvent.Invoke(currentXCoodinate);
        }
    }

    public void PrintMessage(int numberPassed)
    {
        Debug.Log(MessageToPrint + " " + numberPassed.ToString());
    }
}
