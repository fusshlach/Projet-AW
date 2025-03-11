using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Control : MonoBehaviour
{

   // public Animator _doorAnimator;
    public bool _key = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player") && _key == true)
        {
            Debug.Log("t'as la clé");
            Destroy( gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }

}
