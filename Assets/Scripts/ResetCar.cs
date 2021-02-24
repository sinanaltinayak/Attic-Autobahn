using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{
    public GameObject myCar;
    public GameObject lastMark;

    void Update()
    {
        if (Input.GetButtonDown("Reset"))
        {
            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.01f);

        myCar.transform.position = lastMark.transform.position;
    }
}
