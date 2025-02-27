using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArms : MonoBehaviour
{
    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    private Collider2D col;

    private void Start()
    {
        myCam = Camera.main;
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        //ajout tuto Lucas
       // Vector3 PlayerPos = Get.transform;
        Vector3 mouseInScreen = Input.mousePosition;
        mouseInScreen.z = 10;
        Vector3 mouseInWorld = Camera.main.ScreenToWorldPoint(mouseInScreen);
        //transform.position = mouseInWorld;
        transform.position = Vector3.Lerp(transform.position, mouseInScreen, 0.01f);

        //-------------------------------------------------------------------------------------//
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition );
        //Debug.Log(Input.mousePosition);
        //Debug.Log(mousePos);
        //screenPos = myCam.WorldToScreenPoint(transform.position);
        Vector3 vec3 = Input.mousePosition - transform.position;
        angleOffset= 90 - Mathf.Atan2(vec3.y,vec3.x)*Mathf.Rad2Deg;
        //angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x)) - Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;

        //Vector3 vec3 = Input.mousePosition - screenPos;
        //float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;

        // transform.eulerAngles = new Vector3(0, angleOffset, 0);
       Debug.Log("vec 3 " + vec3);
       Debug.Log("angle " + angleOffset);
        transform.rotation = Quaternion.AngleAxis(angleOffset, Vector3.up);



        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (col == Physics2D.OverlapPoint(mousePos))
        //    {
        //        screenPos = myCam.WorldToScreenPoint(transform.position);
        //        Vector3 vec3 = Input.mousePosition - screenPos;
        //        angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x)) - Mathf.Atan2(vec3.y,vec3.x)* Mathf.Rad2Deg;
        //    }
        //}

    //    if (Input.GetMouseButton(0))
    //    {
    //        if(col == Physics2D.OverlapPoint(mousePos))
    //        {
    //            Vector3 vec3 = Input.mousePosition - screenPos;
    //            float angle = Mathf.Atan2(vec3.y,vec3.x) * Mathf.Rad2Deg;
    //            transform.eulerAngles = new Vector3(0,0,angle + angleOffset);
    //        }
    //    }


        
    }
}
