using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redLightA : MonoBehaviour
{
    #region Public Variables
    #endregion //these "regions"
    #region Inspector Variables
    #endregion
    #region Private Variables
    private SpriteRenderer self;
    #endregion
    #region Components
    private StartButton timerCheck; //
    private SequenceTimer timerChanges; // these two reference the scripts and set them to have shortcuts
    #endregion


    private void Start()
    {
        self = gameObject.GetComponent<SpriteRenderer>(); //sets up shortcut for self to be getting the gameObjects Sprite renderer. This allows me to change the colour
        timerCheck = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>(); //Gets the script so it can access the timer to check
        timerChanges = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SequenceTimer>(); //Gets the script so it can access the timer sequence steps
    }

    private void Update()
    {
        if (timerCheck.timer > timerChanges.step1TL ) //if the timer value is greater than the "step 1 traffic light" then it runs the code. Same thing as writing
                                                      //GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>();.timer > GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SequenceTimer>();.step1TL
        {
            self.color = Color.blue; //changes the colour to blue. used as test

        }

        if (timerCheck.timer > timerChanges.step2TL ) //same thing except checks for the second step
        {
            self.color = Color.red; //changes the colour back to red. again, test

        }
    }
}
