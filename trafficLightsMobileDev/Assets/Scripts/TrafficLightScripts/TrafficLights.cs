using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrafficLights : MonoBehaviour
{
    #region Public Variables
    public bool EMERGENCYSTOP = false;
    #endregion
    #region Inspector Variables
    [SerializeField] private TextMeshProUGUI SetARed;
    [SerializeField] private TextMeshProUGUI SetBRed;
    [SerializeField] private TextMeshProUGUI SetAYellow;
    [SerializeField] private TextMeshProUGUI SetBYellow;
    [SerializeField] private TextMeshProUGUI SetAGreen;
    [SerializeField] private TextMeshProUGUI SetBGreen;
    #endregion
    #region Private Variables
    private SpriteRenderer SARed;
    private SpriteRenderer SBRed;
    private SpriteRenderer SAYellow;
    private SpriteRenderer SBYellow;
    private SpriteRenderer SAGreen;
    private SpriteRenderer SBGreen;
    #endregion
    #region Components
    private StartButton timerCheck;
    private SequenceTimer timerChanges;
    private AudioSource alarm;
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
        alarm = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!EMERGENCYSTOP)
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
            if (timerCheck.timer > timerChanges.step4TL)
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
                timerCheck.timer = 0;
            }
        }
        
    }



    #region Functions

    public void SetTrue()
    {
        EMERGENCYSTOP = true;
        alarm.Play();

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
    }

    private void SequenceStep1()
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
