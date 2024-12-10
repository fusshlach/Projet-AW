using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintScript : MonoBehaviour
{
    public bool _isMoving = false;
    public float _movementSpeed = 40;
    //
   [SerializeField] private float _sprintSpeed = 10f;
    [SerializeField] private float _sprintTransitSpeed = 5f;
    [SerializeField] private float _walkSpeed = 5f;
    private float _speed;
    //
    //[Header("keybind")]
    //public KeyCode sprintKey = KeyCode.LeftShift;

   // public MovementState state;
    //public enum MovementState
    //{
    //    walking,
    //    sprinting
    //}


    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {
    //    if(Input.GetKeyDown("arrow"))
    //    {
    //        _isMoving = true;
    //    }
    //    if(Input.GetKeyUp("arrow"))
    //    {
    //        _isMoving = false;
    //    }

    //    if(Input.GetKey(KeyCode.W) & _isMoving == true)
    //    {
    //        transform.position += transform.forward * Time.deltaTime * _movementSpeed;
    //    }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = Mathf.Lerp(_speed, _sprintSpeed, _sprintTransitSpeed *Time.deltaTime);
        }
        else
        {
            _speed = Mathf.Lerp(_speed, _walkSpeed, _sprintTransitSpeed * Time.deltaTime);
        }

    }
}
