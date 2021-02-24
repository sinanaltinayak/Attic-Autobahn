using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{

    public int minCount = 0;
    public int secCount;
    public float milliCount;
    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliDisplay;


    void Start()
    {
        minCount = PlayerPrefs.GetInt("MinSave");
        secCount = PlayerPrefs.GetInt("SecSave");
        milliCount = PlayerPrefs.GetFloat("MilliSave");

        if (minCount <= 9)
        {
            minDisplay.GetComponent<Text>().text = "0" + minCount + ".";
        }
        else
        {
            minDisplay.GetComponent<Text>().text = "" + minCount + ".";
        }

        if (secCount <= 9)
        {
            secDisplay.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            secDisplay.GetComponent<Text>().text = "" + secCount + ".";
        }


        minDisplay.GetComponent<Text>().text = "" + minCount + ":";
        secDisplay.GetComponent<Text>().text = "" + secCount+ ".";
        milliDisplay.GetComponent<Text>().text = "" + milliCount;
    }

}

