using UnityEngine;

public class LookAtMouse3D : MonoBehaviour
{
    public Vector3 rotationOffset = new Vector3(0, 0, 0);

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.forward, transform.position);
        float distance;

        if (groundPlane.Raycast(ray, out distance))
        {
            Vector3 targetPosition = ray.GetPoint(distance);
            Vector3 direction = (targetPosition - transform.position).normalized;

            // Calcul de l'angle de la rotation en Z
            float angleZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Normalisation de l'angle Z pour éviter les oscillations
            angleZ = NormalizeAngle(angleZ);

            // Appliquer l'angle de rotation avec l'offset
            transform.rotation = Quaternion.Euler(0, 0, angleZ) * Quaternion.Euler(rotationOffset);
        }
    }

    // Fonction pour normaliser l'angle entre -180 et 180
    float NormalizeAngle(float angle)
    {
        if (angle > 180)
            angle -= 360;
        else if (angle < -180)
            angle += 360;

        return angle;
    }
}


