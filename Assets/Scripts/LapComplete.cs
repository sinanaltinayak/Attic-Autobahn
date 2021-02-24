using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliDisplay;

    public GameObject lapTimeBox;

    public GameObject lapCounter;
    public int totalLaps;
    private int lapsDone = 1;

    public float rawTime;
    public GameObject raceFinish;

    private void Update()
    {
        if (lapsDone >= totalLaps)
        {
            raceFinish.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        lapsDone += 1;
        rawTime = PlayerPrefs.GetFloat("RawTime");

        if (Timer.rawTime <= rawTime)
        {
            if (Timer.secondCount <= 9)
            {
                secondDisplay.GetComponent<Text>().text = "0" + Timer.secondCount + ".";
            }
            else
            {
                secondDisplay.GetComponent<Text>().text = "" + Timer.secondCount + ".";
            }

            if (Timer.minuteCount <= 9)
            {
                minuteDisplay.GetComponent<Text>().text = "0" + Timer.minuteCount + ".";
            }
            else
            {
                minuteDisplay.GetComponent<Text>().text = "" + Timer.minuteCount + ".";
            }

            milliDisplay.GetComponent<Text>().text = "" + Timer.milliCount;
        }
        PlayerPrefs.SetInt("MinSave", Timer.minuteCount);
        PlayerPrefs.SetInt("SecSave", Timer.secondCount);
        PlayerPrefs.SetFloat("MilliSave", Timer.milliCount);
        PlayerPrefs.SetFloat("RawTime", Timer.rawTime);
        Timer.milliCount = 0;
        Timer.secondCount = 0;
        Timer.minuteCount = 0;
        Timer.rawTime = 0;

        lapCounter.GetComponent<Text>().text = "" + lapsDone + "/" + totalLaps;

        halfLapTrig.SetActive(true);
        lapCompleteTrig.SetActive(false);


    }
}
