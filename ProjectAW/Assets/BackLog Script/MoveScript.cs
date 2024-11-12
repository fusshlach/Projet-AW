using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveScript : MonoBehaviour
{
    public Rigidbody _rgbd;
    public float _moveSpeed;
    private Vector2 _moveDirection;

    public InputActionReference _move;


    private void Update()
    {
        _moveDirection = _move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rgbd.velocity = new Vector2(x: _moveDirection.x * _moveSpeed, y: _moveDirection.y * _moveSpeed);
    }


}
