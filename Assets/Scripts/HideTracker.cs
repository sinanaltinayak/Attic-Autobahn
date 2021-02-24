using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTracker : MonoBehaviour
{
    public GameObject tracker;
    public int mode;

    void Update()
    {
        if (Input.GetButtonDown("HideTracker"))
        {
            if (mode == 1)
            {
                mode = 0;
                tracker.GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                mode = 1;
                tracker.GetComponent<MeshRenderer>().enabled = true;
            }
        }

    }
}
