
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerMove : MonoBehaviour
//{
//    public float _moveSpeed;
//    public Rigidbody2D _rb;
//    private Vector2 _moveDirection;
//    public bool CanMove = true;
//   // public Inventory _inventory;

//   // [SerializeField] InputActionReference _move;

//    // Update is called once per frame
//    void Update()
//    {
//        //Calcul Physiques
//        ProcessInput();

//        // Update character's orientation
//        if (_moveDirection.x < 0) // Right
//        {
//            transform.rotation = Quaternion.Euler(0, 0, 0);
//        }
//        else if (_moveDirection.x > 0)  // Left
//        {
//            transform.rotation = Quaternion.Euler(0, 180, 0);
//        }
//    }
//    private void FixedUpdate()
//    {
//        Move();
//    }

//    void ProcessInput()
//    {        //float moveX = Input.GetAxisRaw("Horizontal");
//        //float moveY = Input.GetAxis("Vertical");
//        //_moveDirection = new Vector2(moveX, moveY);
//        //float moveX = Input.GetAxisRaw("Horizontal");
//        //float moveY = Input.GetAxis("Vertical");
//        //_moveDirection = new Vector2(moveX, moveY);

//      //  _moveDirection = _move.action.ReadValue<Vector2>();
//        Debug.Log(_moveDirection);
//    }

//    void Move()
//    {
//        if (_moveDirection.magnitude > 0.5f && CanMove)
//        {
//            Debug.Log("je bouge");
//            _rb.velocity = new Vector2(_moveDirection.x * _moveSpeed, _moveDirection.y * _moveSpeed);
//        }
//        else
//        {
//            _rb.velocity = Vector2.zero;
//        }
//    }



//}

