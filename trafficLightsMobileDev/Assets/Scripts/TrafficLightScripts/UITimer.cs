using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI timer; //exposes to inspector so unity knows what "timer" is and what text to change
    #endregion
    #region Private Variables
    private float timeKeep; //priv variable especially for this script to keep track of the Timer that doesnt change when emergency stop is pressed
    #endregion
    #region Components
    private StartButton timerGet; //calls start button script so it can be used
    #endregion

    private void Start()
    {
        timerGet = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>(); //loads start button script from scene manager and shortens to "timerGet"
    }

    private void FixedUpdate()
    {
        UpdateTimer();
    }

    #region Functions
    private void UpdateTimer()
    {
        timeKeep = timerGet.constTimer;
        int timeKeepInt = Mathf.RoundToInt(timeKeep);
        timer.text = "Active for " + timeKeepInt.ToString() + " seconds";
    } //rounds the value of timeKeep to an integer and updates text with new number everytime it changes
    #endregion

}
