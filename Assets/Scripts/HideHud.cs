using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideHud : MonoBehaviour
{
    public GameObject hud1;
    public GameObject hud2;
    private int switch1 = 0;

    void Update()
    {
        if (Input.GetButtonDown("HideHUD"))
        {
            if (switch1 == 0)
            {
                switch1 = 1;
                hud1.SetActive(false);
                hud2.SetActive(false);
            }
            else
            {
                switch1 = 0;
                hud1.SetActive(true);
                hud2.SetActive(true);
            }
        }
    }
}
