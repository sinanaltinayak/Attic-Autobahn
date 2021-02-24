using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChange : MonoBehaviour
{
    public GameObject blueCar;
    public GameObject blueCar1;
    public GameObject blueCar2;
    public GameObject redCar;
    public GameObject redCar1;
    public GameObject redCar2;
    public GameObject greenCar;
    public GameObject greenCar1;
    public GameObject greenCar2;
    public int carMode;

    void Update()
    {
        if (Input.GetButtonDown("ChangeCar"))
        {
            if (carMode == 2)
            {
                carMode = 0;
            }
            else
            {
                carMode += 1;
            }
            StartCoroutine(CarChanger());
        }
    }

    IEnumerator CarChanger()
    {

        blueCar.SetActive(false);
        blueCar1.SetActive(false);
        blueCar2.SetActive(false);

        yield return new WaitForSeconds(0.01f);
        if(carMode == 0)
        {
            blueCar.SetActive(true);
            blueCar1.SetActive(true);
            blueCar2.SetActive(true);
            greenCar.SetActive(false);
            greenCar1.SetActive(false);
            greenCar2.SetActive(false);
        }
        if (carMode == 1)
        {
            redCar.SetActive(true);
            redCar1.SetActive(true);
            redCar2.SetActive(true);
            blueCar.SetActive(false);
            blueCar1.SetActive(false);
            blueCar2.SetActive(false);
        }
        if (carMode == 2)
        {
            greenCar.SetActive(true);
            greenCar1.SetActive(true);
            greenCar2.SetActive(true);
            redCar.SetActive(false);
            redCar1.SetActive(false);
            redCar2.SetActive(false);
        }
    }
}
