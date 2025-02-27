using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrasRotation : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 diff;
    private float rotZ;
    Camera viewCamera;
    

    void Update()
    {
        //diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        ////normalize difference  
        //diff.Normalize();

        ////calculate rotation
        //rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        ////apply to object
        //transform.rotation = Quaternion.Euler(0f, 0f, rotZ);


        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane goundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;
        
        if (goundPlane.Raycast(ray, out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
           // controller.LookAt(point);
        }

    }
}