using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    #region Public Variables
    public float timer; //Sets up a private float called "timer"
    public float constTimer; //Same
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    #endregion
    #region Components
    TrafficLights TLManager; //calls traffic light script
    #endregion

    private void Start()
    {
        TLManager = GameObject.FindGameObjectWithTag("TrafficLightManager").GetComponent<TrafficLights>();  //gets traffic light script from TrafficLightManager
    }

    private void Update()
    {
        timer += Time.deltaTime; //Updates timer variable every frame equal to deltaTime
                                 //DeltaTime is a standardiser that ensures the timer
                                 //runs at the same speed everytime
        constTimer += Time.deltaTime;
    }

    #region Functions
    public void SetFalse() //assigned to "start" button
    {
        TLManager.EMERGENCYSTOP = false;
        timer = 0;
        constTimer = 0;
    } //When called, sets emergency stop to false and sets the timers to 0
    #endregion

}
