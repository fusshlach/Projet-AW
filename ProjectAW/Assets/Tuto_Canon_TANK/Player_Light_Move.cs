//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player_Light_Move : MonoBehaviour
//{
//    public Transform _playerAxe;
//    public Transform _lightposition;
//    public float _playerTurnSpeed;
//    public float _lightTurnSpeed;
//    float _playerAngle;
//    float _lightAngle;

    

//    // Update is called once per frame
//    void Update()
//    {
//        RotatePlayer();
//        RotateLight();
//    }

//    void RotatePlayer()
//    {
//        _playerAngle += Input.GetAxis("Mouse X") * _playerTurnSpeed * -Time.deltaTime;
//        _playerAngle = Mathf.Clamp(_playerAngle, 0, 360);
//        _playerAxe.localRotation = Quaternion.AngleAxis(_playerAngle, Vector3.up); //Rotate only on the Y
//    }

//    void RotateLight()
//    {

//    }
//}
