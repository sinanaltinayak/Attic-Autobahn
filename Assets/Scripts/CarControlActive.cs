using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{

    public GameObject carControl;
    public GameObject aiCarControl;

    void Start()
    {
        carControl.GetComponent<CarController>().enabled = true;
        aiCarControl.GetComponent<CarController>().enabled = true;
    }

}
