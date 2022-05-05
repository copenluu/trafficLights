using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAccessCheck : MonoBehaviour
{
    StartButton timerCheck;

    private void Start() //runs on start
    {
        timerCheck = GetComponent<StartButton>(); //sets timerCheck to be "GetComponent<StartButton>(); as a shortcut
    }


    private void OnGUI() //GUI elements
    {
        if (timerCheck.timer > 5) //checks if the timer for the other script is over 5
        {
            Debug.Log("testing part 2"); //sends a debug log after 5s to see if its working
        }
    }
}
