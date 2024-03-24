using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PressingTheQKey : MonoBehaviour
{
    public GameObject PanelHistory;

    void Start()
    {
        PanelHistory.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PanelHistory.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PanelHistory.SetActive(false);
        }
    }
}
