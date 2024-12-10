using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeplacements : MonoBehaviour
{
    public float _speed = 5.0f;
    private float _horizontalInput;
    //private float _verticalInput;
    private float _forwardInput;
    //ajout Sprint 2
    public bool _sprint;

    //ajout pour le sprint
  //  [SerializeField] private Movement _movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //etat sprint au lors du lancement du jeu 
        //Debug.Log(_movement._isSprinting);
       // ApplyMovement();

        //fin ajout sprint

        //get player Input
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        //move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * _speed * _horizontalInput);
    }

    //a été crée pour le sprint
    //  private void ApplyMovement()
    //  {
    //     var targetSpeed = !_movement._isSprinting ? _movement._sprintSpeed : _movement._sprintSpeed * _movement._multiplier;
    //      _movement._currentSpeed = Mathf.MoveTowards(_movement._currentSpeed, targetSpeed, _movement._acceleration * Time.deltaTime);

    //     throw new NotImplementedException();
    //  }

    //Ajout du sprint

    //  public void Sprint(InputAction.CallbackContext context)
    //  {
    //     _movement._isSprinting = context.started || context.performed;
    //  }

    //  [Serializable]
    //  public struct Movement
    //  {
    //      public float _sprintSpeed;
    //      public float _multiplier;
    //      public float _acceleration;
    //     [HideInInspector] public bool _isSprinting;
    //     public float _currentSpeed;
    // }

    //Test2 Sprint
    void OnSprintAction(InputValue value) 
    {
        _sprint = value.isPressed;
    }

}
