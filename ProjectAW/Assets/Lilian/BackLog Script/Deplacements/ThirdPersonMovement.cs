using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController _controller;
    public Transform _cam;

    public float _speed = 5f;

    public float _turnSmoothTime = 0.1f;
    float _turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal,0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float _targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg; //+ _cam.eulerAngles.y; //
            float _angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetAngle, ref _turnSmoothVelocity, _turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, _angle, 0f);

            Vector3 _moveDir = Quaternion.Euler(0f, _targetAngle, 0f) * Vector3.forward;
            _controller.Move(_moveDir * _speed * Time.deltaTime);
        }

    }
}
