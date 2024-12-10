//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Flashlight_ON_OFF : MonoBehaviour
//{
//    public GameObject _flashlight;

//    public AudioSource _turnON;
//    public AudioSource _turnOFF;

//    public bool _ON;
//    public bool _OFF;

//    // Start is called before the first frame update
//    void Start()
//    {
//        _OFF = true;
//        _flashlight.SetActive(false);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (_OFF && Input.GetButtonDown("F"))
//        {
//            _flashlight.SetActive(true);
//            _turnON.Play();
//            _OFF = false;
//            _ON = true;
//        }

//        else if (Input.GetButtonDown("F"))
//        {
//            _flashlight.SetActive(false);
//            _turnOFF.Play();
//            _OFF = true;
//            _ON = false;
//        }

//    }
//}
