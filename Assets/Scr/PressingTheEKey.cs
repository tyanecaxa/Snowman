using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressingTheEKey : MonoBehaviour
{
    public GameObject PanelConsol;

    private void Start()
    {
        PanelConsol.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PanelConsol.SetActive(true);
            
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PanelConsol.SetActive(false);
        }
    }
}
