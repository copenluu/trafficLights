using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TrafficLights : MonoBehaviour
{
    #region Public Variables
    public bool emergencyStop = false; //sets emergency stop to public so other scripts can access it and sets to false by default
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI SetARed;
    [SerializeField] private TextMeshProUGUI SetBRed;
    [SerializeField] private TextMeshProUGUI SetAYellow;
    [SerializeField] private TextMeshProUGUI SetBYellow;
    [SerializeField] private TextMeshProUGUI SetAGreen;
    [SerializeField] private TextMeshProUGUI SetBGreen; //the text elements for accessibility can be changed by being assigned in inspector
    [SerializeField] private Button stopButton; //
    [SerializeField] private Button startButton; //assigns stop and start button in inspector
    #endregion
    #region Private Variables
    private SpriteRenderer SARed;
    private SpriteRenderer SBRed;
    private SpriteRenderer SAYellow;
    private SpriteRenderer SBYellow;
    private SpriteRenderer SAGreen;
    private SpriteRenderer SBGreen; //calls the "sprite" part of the traffic lights so I can change the colour
    #endregion
    #region Components
    private StartButton timerCheck; //
    private SequenceTimer timerChanges; //calls from other scripts so they can be used here
    private AudioSource alarm; //component to play audio
    #endregion

    private void Start()
    {
        SARed = GameObject.FindGameObjectWithTag("SARed").GetComponent<SpriteRenderer>(); //
        SBRed = GameObject.FindGameObjectWithTag("SBRed").GetComponent<SpriteRenderer>(); //
        SAYellow = GameObject.FindGameObjectWithTag("SAYellow").GetComponent<SpriteRenderer>(); //
        SBYellow = GameObject.FindGameObjectWithTag("SBYellow").GetComponent<SpriteRenderer>();//
        SAGreen = GameObject.FindGameObjectWithTag("SAGreen").GetComponent<SpriteRenderer>(); //
        SBGreen = GameObject.FindGameObjectWithTag("SBGreen").GetComponent<SpriteRenderer>(); //I moved the script from the colour to the object its inside, so I am re-establishing the colour changing option
        timerCheck = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<StartButton>(); //Gets the script so it can access the timer to check
        timerChanges = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SequenceTimer>(); //Gets the script so it can access the timer sequence steps
        alarm = GetComponent<AudioSource>(); //lets me play audio as it gets audiosource from current game object
    }

    private void Update()
    {
        if (!emergencyStop)
        {
            if (timerCheck.timer > timerChanges.step0TL)
            {
                SequenceStep1();
            }
            if (timerCheck.timer > timerChanges.step1TL)
            {
                SequenceStep2();
            }
            if (timerCheck.timer > timerChanges.step2TL)
            {
                SequenceStep3();
            }
            if (timerCheck.timer > timerChanges.step3TL)
            {
                SequenceStep4();
            }
            if (timerCheck.timer > timerChanges.step4TL) //changes traffic lights depending on what the value of "timer" is, and if its larger than the next step 
            {
                SequenceStep5();
            }
            if (timerCheck.timer > timerChanges.step5TL)
            {
                SequenceStep6();
            }
            if (timerCheck.timer > timerChanges.step6TL)
            {
                SequenceStep7();
            }
            if (timerCheck.timer > timerChanges.step7TL)
            {
                SequenceStep8();
            }
            if (timerCheck.timer > timerChanges.step8TL)
            {
                timerCheck.timer = 0; //resets to 0 to start loop all over again
            }
        }
        
    }



    #region Functions

    public void SetTrue() //function to set emergency stop true. assigned to "emergency stop" button
    {
        emergencyStop = true; //changed to camel naming convention
        alarm.Play(); //plays alarm audio clip component, aka alarm noise

        timerCheck.timer = 0;

        SARed.color = Color.red;
        SBRed.color = Color.red;
        SetARed.text = "ON";
        SetBRed.text = "ON";
        SAYellow.color = Color.grey;
        SBYellow.color = Color.grey;
        SetAYellow.text = "OFF";
        SetBYellow.text = "OFF";
        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";

        stopButton.interactable = false; //once this function is called, the stop button stops being interactable
        startButton.interactable = true; //the start button is now interactable again
    }

    private void SequenceStep1() //a lot of repetition. runs through sequence and changes to what is needed for that sequence.
    {
        SARed.color = Color.red;
        SBRed.color = Color.red;
        SetARed.text = "ON";
        SetBRed.text = "ON";

        SAYellow.color = Color.grey;
        SBYellow.color = Color.grey;
        SetAYellow.text = "OFF";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";

        
    }

    private void SequenceStep2()
    {
        SARed.color = Color.red;
        SBRed.color = Color.red;
        SetARed.text = "ON";
        SetBRed.text = "ON";

        SAYellow.color = Color.grey;
        SBYellow.color= Color.yellow;
        SetAYellow.text = "OFF";
        SetBYellow.text = "ON";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";
    }

    private void SequenceStep3()
    {
        SARed.color = Color.red;
        SBRed.color = Color.grey;
        SetARed.text = "ON";
        SetBRed.text = "OFF";

        SAYellow.color = Color.grey;
        SBYellow.color = Color.grey;
        SetAYellow.text = "OFF";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.green;
        SetAGreen.text = "OFF";
        SetBGreen.text = "ON";
    }

    private void SequenceStep4()
    {
        SARed.color = Color.red;
        SBRed.color = Color.grey;
        SetARed.text = "ON";
        SetBRed.text = "OFF";

        SAYellow.color = Color.grey;
        SBYellow.color = Color.yellow;
        SetAYellow.text = "OFF";
        SetBYellow.text = "ON";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";
    }

    private void SequenceStep5()
    {
        SARed.color = Color.red;
        SBRed.color = Color.red;
        SetARed.text = "ON";
        SetBRed.text = "ON";

        SAYellow.color = Color.grey;
        SBYellow.color = Color.grey;
        SetAYellow.text = "OFF";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";
    }

    private void SequenceStep6()
    {
        SARed.color = Color.red;
        SBRed.color = Color.red;
        SetARed.text = "ON";
        SetBRed.text = "ON";

        SAYellow.color = Color.yellow;
        SBYellow.color = Color.grey;
        SetAYellow.text = "ON";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";
    }

    private void SequenceStep7()
    {
        SARed.color = Color.grey;
        SBRed.color = Color.red;
        SetARed.text = "OFF";
        SetBRed.text = "ON";

        SAYellow.color = Color.grey;
        SBYellow.color = Color.grey;
        SetAYellow.text = "OFF";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.green;
        SBGreen.color = Color.grey;
        SetAGreen.text = "ON";
        SetBGreen.text = "OFF";
    }

    private void SequenceStep8()
    {
        SARed.color = Color.grey;
        SBRed.color = Color.red;
        SetARed.text = "OFF";
        SetBRed.text = "ON";

        SAYellow.color = Color.yellow;
        SBYellow.color = Color.grey;
        SetAYellow.text = "ON";
        SetBYellow.text = "OFF";

        SAGreen.color = Color.grey;
        SBGreen.color = Color.grey;
        SetAGreen.text = "OFF";
        SetBGreen.text = "OFF";
    }



    #endregion

}
