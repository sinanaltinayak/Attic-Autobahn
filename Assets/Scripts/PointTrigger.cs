using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;

    private void OnTriggerEnter()
    {
        lapCompleteTrig.SetActive(true);
        halfLapTrig.SetActive(false);

    }
}
