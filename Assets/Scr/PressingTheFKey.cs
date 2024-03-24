using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressingTheFKey : MonoBehaviour
{
    public Menu _menu;
    public GameObject gameplayUI;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            _menu.gameObject.SetActive(false);

            _menu.player.GetComponent<PlayerController>().enabled = true;
            _menu.player.GetComponent<CameraRotation>().enabled = true;
            _menu.player.GetComponent<HumanoidController>().enabled = true;
            _menu.player.GetComponent<CharacterController>().enabled = true;
            _menu.player.GetComponent<FireballCaster>().enabled = true;

            _menu.santa.gameObject.SetActive(true);

            gameplayUI.SetActive(true);
        }
    }
}
