using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    PlayerInput _playerInput;
    InputAction _moveAction;
    [SerializeField] float _playerSpeed = 5;
    public Rigidbody2D _rb;
    private Vector2 _moveDirection;
    public bool CanMove = true;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions.FindAction("Move");
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovePlayer()
    {
        Vector2 direction = _moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * _playerSpeed * Time.deltaTime;
    }
}
