using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI timer;
    #endregion
    #region Private Variables
    private float timeKeep;
    #endregion
    #region Components
    private StartButton timerGet;
    #endregion

    private void Start()
    {
        timerGet = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>();
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
    }
    #endregion

}
