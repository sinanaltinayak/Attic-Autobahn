using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{
    public GameObject countdown;
    public AudioSource getReady;
    public AudioSource go;
    public GameObject lapTimer;
    public GameObject carUserControl;
    public AudioSource levelMusic;

    public GameObject label;
    public GameObject text;


    void Start()
    {
        StartCoroutine(hints());

        StartCoroutine(CountStart());
    }

    IEnumerator hints()
    {
        text.GetComponent<Text>().text = "WASD to move";
        yield return new WaitForSeconds(3);
        text.GetComponent<Text>().text = "C to change camera";
        yield return new WaitForSeconds(3);
        text.GetComponent<Text>().text = "R to reset car";
        yield return new WaitForSeconds(3);

        label.SetActive(false);
        text.SetActive(false);
    }

    IEnumerator CountStart()
    {


        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);

        countdown.GetComponent<Text>().text = "2";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);

        countdown.GetComponent<Text>().text = "1";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);

        go.Play();
        lapTimer.SetActive(true);

        levelMusic.Play();

        carUserControl.GetComponent<CarUserControl>().enabled = true;
        carUserControl.GetComponent<CarController>().enabled = true;



    }

}
