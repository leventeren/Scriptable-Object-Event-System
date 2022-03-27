using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO.Events;

public class TestScript : MonoBehaviour
{
    [SerializeField] private VoidEvent OnGameStart;
    [SerializeField] private IntEvent OnValue;

    [SerializeField] float myTestVal = 5;
    bool isCountDown = true;
    void Start()
    {
        Debug.Log("Game Started!");
        OnGameStart.Raise();
    }

    private void Update()
    {
        if (isCountDown)
        {
            myTestVal -= Time.deltaTime;
            if (myTestVal < 0)
            {
                Debug.Log("Countdown Stoped!");
                OnValue.Raise((int)myTestVal);
                isCountDown = false;
            }
        }
    }
}
