using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class Dreamcar01Tracker : MonoBehaviour
{
    public GameObject marker;

    public GameObject mark001;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
    public GameObject mark20;
    public GameObject mark21;
    public GameObject mark22;
    public GameObject mark23;
    public GameObject mark24;
    public int markTracker;

    public GameObject checkpointDisplay;
    public int totalCheckpoint;
    public GameObject myCar;


    void Update()
    {
        checkpointDisplay.GetComponent<Text>().text = "" + (markTracker + 2) + "/"+ totalCheckpoint;


        if (markTracker == -1)
        {
            marker.GetComponent<CapsuleCollider>().radius = 1;
            marker.transform.position = mark001.transform.position;
        }

        if (markTracker == 0)
        {
            marker.transform.position = mark01.transform.position;
        }

        if (markTracker == 1)
        {
            marker.transform.position = mark02.transform.position;
        }

        if (markTracker == 2)
        {
            marker.transform.position = mark03.transform.position;
        }

        if (markTracker == 3)
        {
            marker.transform.position = mark04.transform.position;
        }

        if (markTracker == 4)
        {
            marker.transform.position = mark05.transform.position;
        }
        if (markTracker == 5)
        {
            marker.transform.position = mark06.transform.position;
        }
        if (markTracker == 6)
        {
            marker.transform.position = mark07.transform.position;
        }
        if (markTracker == 7)
        {
            marker.transform.position = mark08.transform.position;
        }
        if (markTracker == 8)
        {
            marker.transform.position = mark09.transform.position;
        }
        if (markTracker == 9)
        {
            marker.transform.position = mark10.transform.position;
        }
        if (markTracker == 10)
        {
            marker.transform.position = mark11.transform.position;
            marker.GetComponent<CapsuleCollider>().radius = 2;
        }
        if (markTracker == 11)
        {
            marker.GetComponent<CapsuleCollider>().radius = 1;
            marker.transform.position = mark12.transform.position;
        }
        if (markTracker == 12)
        {
            marker.transform.position = mark13.transform.position;
        }
        if (markTracker == 13)
        {
            marker.transform.position = mark14.transform.position;
        }
        if (markTracker == 14)
        {
            marker.transform.position = mark15.transform.position;
        }
        if (markTracker == 15)
        {
            marker.transform.position = mark16.transform.position;
        }
        if (markTracker == 16)
        {
            marker.transform.position = mark17.transform.position;
        }
        if (markTracker == 17)
        {
            marker.transform.position = mark18.transform.position;
        }
        if (markTracker == 18)
        {
            marker.transform.position = mark19.transform.position;
        }
        if (markTracker == 19)
        {
            marker.transform.position = mark20.transform.position;
        }
        if (markTracker == 20)
        {
            marker.transform.position = mark21.transform.position;
        }
        if (markTracker == 21)
        {
            marker.transform.position = mark22.transform.position;
        }
        if (markTracker == 22)
        {
            marker.transform.position = mark23.transform.position;
        }
        if (markTracker == 23)
        {
            marker.GetComponent<CapsuleCollider>().radius = 2;
            marker.transform.position = mark24.transform.position;
        }
        if (Input.GetButtonDown("Reset"))
        {
            StartCoroutine(Reset());
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<CapsuleCollider>().enabled = false;
            markTracker += 1;
            if(markTracker >= 24)
            {
                markTracker = -1;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.01f);

        myCar.GetComponent<Rigidbody>().velocity = Vector2.zero;
        myCar.GetComponent<Rigidbody>().angularVelocity = Vector2.zero;

        if (markTracker == -1)
        {
            myCar.transform.eulerAngles = new Vector3(0, 90, 0);
            myCar.transform.position = mark001.transform.position;
        }

        if (markTracker == 1)
        {
            myCar.transform.eulerAngles = new Vector3(0, 180, 0);
            myCar.transform.position = mark01.transform.position;
        }

        if (markTracker ==2 || markTracker == 3)
        {
            myCar.transform.eulerAngles = new Vector3(0, 180, 0);
            myCar.transform.position = mark02.transform.position;
        }

        if (markTracker == 4)
        {
            myCar.transform.eulerAngles = new Vector3(0, 270, 0);
            myCar.transform.position = mark04.transform.position;
        }

        if (markTracker == 5)
        {
            myCar.transform.eulerAngles = new Vector3(0, 90, 0);
            myCar.transform.position = mark05.transform.position;
        }
        if (markTracker == 6)
        {
            myCar.transform.eulerAngles = new Vector3(0, 0, 0);
            myCar.transform.position = mark06.transform.position;
        }
        if (markTracker == 7)
        {
            myCar.transform.eulerAngles = new Vector3(0, 180, 0);
            myCar.transform.position = mark07.transform.position;
        }
        if (markTracker == 8)
        {
            myCar.transform.eulerAngles = new Vector3(0, 90, 0);
            myCar.transform.position = mark08.transform.position;
        }
        if (markTracker == 9)
        {
            myCar.transform.eulerAngles = new Vector3(0, 0, 0);
            myCar.transform.position = mark09.transform.position;
        }
        if (markTracker == 10 || markTracker == 11)
        {
            myCar.transform.eulerAngles = new Vector3(0, 270, 0);
            myCar.transform.position = mark10.transform.position;
        }
        if (markTracker == 12 || markTracker ==13)
        {
            myCar.transform.eulerAngles = new Vector3(0, 270, 0);
            myCar.transform.position = mark12.transform.position;
        }
        if (markTracker == 14)
        {
            myCar.transform.eulerAngles = new Vector3(0, 0, 0);
            myCar.transform.position = mark14.transform.position;
        }
        if (markTracker == 15)
        {
            myCar.transform.eulerAngles = new Vector3(0, 90, 0);
            myCar.transform.position = mark15.transform.position;
        }
        if (markTracker == 16)
        {
            myCar.transform.eulerAngles = new Vector3(0, 315, 0);
            myCar.transform.position = mark16.transform.position;
        }
        if (markTracker == 17)
        {
            myCar.transform.eulerAngles = new Vector3(0, 45, 0);
            myCar.transform.position = mark17.transform.position;
        }
        if (markTracker == 18)
        {
            myCar.transform.eulerAngles = new Vector3(0, 170, 0);
            myCar.transform.position = mark18.transform.position;
        }
        if (markTracker == 19)
        {
            myCar.transform.eulerAngles = new Vector3(0, 180, 0);
            myCar.transform.position = mark19.transform.position;
        }
        if (markTracker == 20)
        {
            myCar.transform.eulerAngles = new Vector3(0, 270, 0);
            myCar.transform.position = mark20.transform.position;
        }
        if (markTracker == 21)
        {
            myCar.transform.eulerAngles = new Vector3(0, 350, 0);
            myCar.transform.position = mark21.transform.position;
        }
        if (markTracker == 22)
        {
            myCar.transform.eulerAngles = new Vector3(0, 90, 0);
            myCar.transform.position = mark22.transform.position;
        }
        if (markTracker == 23)
        {
            myCar.transform.eulerAngles = new Vector3(0, 0, 0);
            myCar.transform.position = mark23.transform.position;
        }
        if (markTracker == 24)
        {
            myCar.transform.eulerAngles = new Vector3(0, 330, 0);
            myCar.transform.position = mark24.transform.position;
        }


    }
}
