using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    #region Public Variables
    public float timer; //Sets up a private float called "timer"
    public float constTimer;
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    #endregion
    #region Components
    TrafficLights TLManager;
    #endregion

    private void Start()
    {
        TLManager = GameObject.FindGameObjectWithTag("TrafficLightManager").GetComponent<TrafficLights>();        
    }

    private void Update()
    {
        timer += Time.deltaTime; //Updates timer variable every frame equal to deltaTime
                                 //DeltaTime is a standardiser that ensures the timer
                                 //runs at the same speed everytime
        constTimer += Time.deltaTime;
    }

    #region Functions
    public void SetFalse()
    {
        TLManager.EMERGENCYSTOP = false;
        timer = 0;
        constTimer = 0;
    }
    #endregion

}
