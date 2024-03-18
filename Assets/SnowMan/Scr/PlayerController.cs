using System.Collections;using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    public float Speed;

    private CharacterController _CharacterController;
    private Vector3 _moveVector;
    private float _fallVelocity = 0;

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

        _fallVelocity += gravity * Time.fixedDeltaTime;
        _CharacterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if(_CharacterController.isGrounded)
        {
            _fallVelocity = 0;
        }
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
