using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public GameObject LightSource;

    private bool isOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (!isOn)
            {
                //LightOn();
                Invoke("LightOn", 0.3f);
            }

            else
            {
                //LightOff();
                Invoke("LightOff", 0.3f);
            }
        }
    }

    void LightOn()
    {
        LightSource.SetActive(true);
        isOn = true;
    }

    void LightOff()
    {
        LightSource.SetActive(false);
        isOn = false;
    }
}
