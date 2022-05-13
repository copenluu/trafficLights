using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceTimer : MonoBehaviour
{
    public int step0TL;
    public int step1TL;
    public int step2TL;
    public int step3TL;
    public int step4TL;
    public int step5TL;
    public int step6TL;
    public int step7TL;
    public int step8TL;
    public int resetTimer;
    //establishes the timers as public variables and ints 
    //so it can be accessed from other scripts 

    private void Start()
    {
        step0TL = 0;
        step2TL += step1TL;
        step3TL += step2TL;
        step4TL += step3TL;
        step5TL += step4TL;
        step6TL += step5TL;
        step7TL += step6TL;
        step8TL += step7TL;
    } //adds the values together for the user
}
