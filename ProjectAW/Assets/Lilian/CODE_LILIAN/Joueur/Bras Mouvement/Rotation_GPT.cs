using Unity.VisualScripting;
using UnityEngine;

//public class LookAtMouse3D : MonoBehaviour
//{

//    public Vector3 rotationOffset = new Vector3(0, 0, 90); // Ajuste selon l'orientation du sprite
//    void Update()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        Plane groundPlane = new Plane(Vector3.up, transform.position);
//        float distance;

//        if (groundPlane.Raycast(ray, out distance))
//        {
//            Vector3 targetPosition = ray.GetPoint(distance);
//            Vector3 direction = targetPosition - transform.position;
//            direction.y = 0f; // On garde l'objet aligné avec le sol

//            float offsetAngle = 90f; // Change cette valeur selon l'orientation de ton sprite

//            // Correction pour que l'axe Y soit la référence de rotation avec un décalage
//            Quaternion targetRotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, offsetAngle, 0);
//            transform.rotation = targetRotation;
//        }
//    }
//}

