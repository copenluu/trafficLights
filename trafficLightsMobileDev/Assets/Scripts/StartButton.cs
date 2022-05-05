using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    #region Public Variables
    public float timer; //Sets up a private float called "timer"
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    #endregion
    #region Components
    #endregion


    private void Update()
    {
        timer += Time.deltaTime; //Updates timer variable every frame equal to deltaTime
                                 //DeltaTime is a standardiser that ensures the timer
                                 //runs at the same speed everytime
    }

    private void OnGUI()
    {
        if (timer < 2)
        {
            Debug.Log("timer worked");
        }
    }

}
