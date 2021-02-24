using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoiceCam : MonoBehaviour
{
    public static int carType = 1;
    public GameObject selectButton;

    public GameObject blueBody;
    public GameObject blueLeftMudder;
    public GameObject blueRightMudder;

    public GameObject redBody;
    public GameObject redLeftMudder;
    public GameObject redRightMudder;

    public GameObject greenBody;
    public GameObject greenLeftMudder;
    public GameObject greenRightMudder;

    private void Update()
    {
        if (carType == 1)
        {
            blueBody.SetActive(true);
            blueLeftMudder.SetActive(true);
            blueRightMudder.SetActive(true);
            redBody.SetActive(false);
            redLeftMudder.SetActive(false);
            redRightMudder.SetActive(false);
            greenBody.SetActive(false);
            greenLeftMudder.SetActive(false);
            greenRightMudder.SetActive(false);
        }

        if (carType == 2)
        {
            redBody.SetActive(true);
            redLeftMudder.SetActive(true);
            redRightMudder.SetActive(true);
            blueBody.SetActive(false);
            blueLeftMudder.SetActive(false);
            blueRightMudder.SetActive(false);
            greenBody.SetActive(false);
            greenLeftMudder.SetActive(false);
            greenRightMudder.SetActive(false);
        }

        if (carType == 3)
        {
            blueBody.SetActive(false);
            blueLeftMudder.SetActive(false);
            blueRightMudder.SetActive(false);
            redBody.SetActive(false);
            redLeftMudder.SetActive(false);
            redRightMudder.SetActive(false);
            greenBody.SetActive(true);
            greenLeftMudder.SetActive(true);
            greenRightMudder.SetActive(true);
        }
    }


    public void blueCar()
    {
        carType = 1;
        selectButton.SetActive(true);
    }

    public void redCar()
    {
        carType = 2;
        selectButton.SetActive(true);
    }
    public void greenCar()
    {
        carType = 3;
        selectButton.SetActive(true);
    }


}
