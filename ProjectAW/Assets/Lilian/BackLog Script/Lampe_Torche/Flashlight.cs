//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;

//public class Flashlight : MonoBehaviour
//{
//    public Light _light;
//    public TMP_Text _text;
//    public TMP_Text _batteryText;
//    public float _lifeTime = 100;
//    public float _battery = 0;

//    public AudioSource _flashOn;
//    public AudioSource _flashOff;

//    private bool _on;
//    private bool _off;



//    // Start is called before the first frame update
//    void Start()
//    {
//        _text.text = "Flashlight : " + _lifeTime + "%";
//        _light = GetComponent<Light>();

//        _off = true;
//        _light.enabled = false;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        _text.text = _lifeTime.ToString("0") + "%";
//        _batteryText.text =_battery.ToString();

//        if (Input.GetButtonDown("Flashlight")&& _off)
//        {
//            _flashOn.Play();
//            _light.enabled = true;
//            _on = true;
//            _off = false;
//        }

//        else if (Input.GetButtonDown("Flashlight") && _on)
//        {
//            _flashOff.Play();
//            _light.enabled = false;
//            _on = false;
//            _off = true;
//        }

//        if (_on)
//        {
//            _lifeTime -= 1 * Time.deltaTime;
//        }

//        if (_lifeTime <= 0)
//        {
//            _light.enabled = false;
//            _on = false;
//            _off = true;
//            _lifeTime = 0;
//        }

//        if (_lifeTime >= 100)
//        {
//            _lifeTime = 100;
//        }

//        if (Input.GetButtonDown("Reload") && _battery >= 1)
//        {
//            _battery -= 1;
//            _lifeTime += 50;
//        }

//        if (Input.GetButtonDown("Reload") && _battery == 0)
//        {
//            return;
//        }

//        if (_battery <= 0)
//        {
//            _battery = 0;
//        }
//    }
//}
