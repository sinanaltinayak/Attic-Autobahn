using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int carType;
    public GameObject selectButton;

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
