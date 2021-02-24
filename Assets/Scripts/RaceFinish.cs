using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;


public class RaceFinish : MonoBehaviour
{
    public GameObject myCar;
    public GameObject finishCam;
    public GameObject viewModes;
    public GameObject levelMusic;
    public AudioSource cheer;

    public GameObject yourTime;

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        myCar.GetComponent<CarAudio>().enabled = false;

        myCar.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        myCar.GetComponent<CarController>().enabled = false;
        myCar.GetComponent<CarUserControl>().enabled = false;

        myCar.SetActive(true);
        finishCam.SetActive(true);
        levelMusic.SetActive(false);
        viewModes.SetActive(false);
        cheer.Play();

        yourTime.SetActive(true);

        yourTime.GetComponent<Text>().text = "You did it!";

        StartCoroutine (gocredits());

    }

       IEnumerator gocredits()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

}

