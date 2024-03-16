using System.Collections;using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float Speed;

    private CharacterController _CharacterController;
    private Vector3 _moveVector;

    void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveUpdate();
    }
    
    void FixedUpdate()
    {
        _CharacterController.Move(_moveVector * Speed * Time.fixedDeltaTime);
    }

    private void MoveUpdate()
    {
        _moveVector = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        {
            _moveVector -= transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _moveVector += transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _moveVector += transform.right;
        }

        if (Input .GetKey(KeyCode.D))
        {
            _moveVector -= transform.right;
        }
    }
}
