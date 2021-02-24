using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    public GameObject theCar;
    public float CarX;
    public float CarY;
    public float CarZ;

    void Update()
    {
        CarX = theCar.transform.eulerAngles.x;
        CarY = theCar.transform.eulerAngles.y;
        CarZ = theCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX-CarX, CarY, CarZ-CarZ);
    }   
}
