using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneCams : MonoBehaviour
{
    public GameObject normalCam;
    public GameObject farCam;
    public GameObject FPCam;
    public GameObject wheelCam;
    public GameObject topCam;
    public GameObject frontCam;
    public GameObject profileCam;
    public GameObject finishCam;
    public GameObject rampCam;
    public GameObject chessCam;
    public GameObject couchCam;
    public GameObject cardsCam;
    public GameObject tableCam;
    public GameObject dominoCam;
    public GameObject backCam;
    public int camMode;

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (camMode == 14)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            normalCam.SetActive(true);
            backCam.SetActive(false);
        }
        if (camMode == 1)
        {
            farCam.SetActive(true);
            normalCam.SetActive(false);
        }
        if (camMode == 2)
        {
            FPCam.SetActive(true);
            farCam.SetActive(false);
        }
        if (camMode == 3)
        {
            FPCam.SetActive(false);
            wheelCam.SetActive(true);
        }
        if (camMode == 4)
        {
            wheelCam.SetActive(false);
            topCam.SetActive(true);
        }
        if (camMode == 5)
        {
            topCam.SetActive(false);
            frontCam.SetActive(true);
        }
        if (camMode == 6)
        {
            frontCam.SetActive(false);
            finishCam.SetActive(true);
        }
        if (camMode == 7)
        {
            finishCam.SetActive(false);
            rampCam.SetActive(true);
        }
        if (camMode == 8)
        {
            rampCam.SetActive(false);
            chessCam.SetActive(true);
        }
        if (camMode == 9)
        {
            chessCam.SetActive(false);
            couchCam.SetActive(true);
        }
        if (camMode == 10)
        {
            couchCam.SetActive(false);
            cardsCam.SetActive(true);
        }
        if (camMode == 11)
        {
            cardsCam.SetActive(false);
            tableCam.SetActive(true);
        }
        if (camMode == 12)
        {
            tableCam.SetActive(false);
            dominoCam.SetActive(true);
        }
        if (camMode == 13)
        {
            dominoCam.SetActive(false);
            profileCam.SetActive(true);
        }
        if (camMode == 14)
        {
            profileCam.SetActive(false);
            backCam.SetActive(true);
        }
    }
}
