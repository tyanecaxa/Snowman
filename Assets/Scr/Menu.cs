using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject player;
    public GameObject santa;

    void Start()
    {        
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<CameraRotation>().enabled = false;
        player.GetComponent<HumanoidController>().enabled = false;
        player.GetComponent<CharacterController>().enabled = false;
        player.GetComponent<FireballCaster>().enabled = false;

        santa.gameObject.SetActive(false);
    }

}
