using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{

    public GameObject blueBody;
    public GameObject blueLeftMudder;
    public GameObject blueRightMudder;

    public GameObject redBody;
    public GameObject redLeftMudder;
    public GameObject redRightMudder;

    public GameObject greenBody;
    public GameObject greenLeftMudder;
    public GameObject greenRightMudder;

    public int carImport;
    void Start()
    {
        carImport = CarChoiceCam.carType;
        if (carImport == 1)
        {
            blueBody.SetActive(true);
            blueLeftMudder.SetActive(true);
            blueRightMudder.SetActive(true);
        }

        if (carImport == 2)
        {
            redBody.SetActive(true);
            redLeftMudder.SetActive(true);
            redRightMudder.SetActive(true);
        }
       
        if (carImport == 3)
        {
            greenBody.SetActive(true);
            greenLeftMudder.SetActive(true);
            greenRightMudder.SetActive(true);
        }
    }

}
