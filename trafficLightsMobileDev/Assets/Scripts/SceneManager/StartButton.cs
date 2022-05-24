using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    #region Public Variables
    public float timer; //Sets up a private float called "timer"
    public float constTimer; //Same
    #endregion
    #region Inspector Variables
    [SerializeField] private Button startButton; //
    [SerializeField] private Button stopButton; //assigns start and stop button in the inspector
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
        stopButton.interactable = true; //when this script runs, the stop button is now interactable again
        startButton.interactable = false; //the start button is no longer interactable when run
    }

    #region Functions
    public void SetFalse() //assigned to "start" button
    {
        TLManager.emergencyStop = false;
        timer = 0;
        constTimer = 0;
    } //When called, sets emergency stop to false and sets the timers to 0
    #endregion

}
