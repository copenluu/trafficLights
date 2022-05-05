using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redLightA : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private Color StartColor;
    [SerializeField] private Color EndColor;
    #endregion
    #region Private Variables
    private SpriteRenderer self;
    private bool changeColour = true;
    private bool changeColour2 = false;
    #endregion
    #region Components
    private StartButton timerCheck;
    private SequenceTimer timerChanges;
    #endregion


    private void Start()
    {
        self = gameObject.GetComponent<SpriteRenderer>();
        timerCheck = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>();
        timerChanges = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SequenceTimer>();
    }

    private void Update()
    {
        if (timerCheck.timer > timerChanges.step1TL ) 
        {
            self.color = Color.blue;

        }

        if (timerCheck.timer > timerChanges.step2TL )
        {
            self.color = Color.red;

        }
    }
}
