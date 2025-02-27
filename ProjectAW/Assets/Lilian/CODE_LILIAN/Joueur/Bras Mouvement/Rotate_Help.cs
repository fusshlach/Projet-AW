using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Rotate_Help : MonoBehaviour
{
    [SerializeField] LayerMask _layerMask;
    [SerializeField] Transform _parent; //Parent Object
    [SerializeField] float _smooth = 1000;

    RaycastHit _hit;
    Vector3 _directionToLook;

    [SerializeField] Transform _baseBras;

    [SerializeField] Sprite _avantSprite;
    [SerializeField] Sprite _arriereSprite;
    [SerializeField] Image _image;

    float _filled = 0.05f;


    //void RotationStart()

    void Update ()
    {
        
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out _hit, Mathf.Infinity, _layerMask))
        {
            // Give position by hit point
            _directionToLook = new Vector3(_hit.point.x, _hit.point.y, _baseBras.position.z) - _baseBras.position;
            //transform souris - transform de l'objet

            Debug.Log("le code se lance");
            // Rotation to direction
            if (_directionToLook != Vector3.zero)
            {
                // Translate the direction to the rotation
                Quaternion targetRotation = Quaternion.LookRotation(_directionToLook); //quaternion fait le calcul à partir de la position de la sourie
                // Smoothing the rotation
                _baseBras.rotation = Quaternion.Slerp(_baseBras.rotation, targetRotation, Time.deltaTime * _smooth); //Quaternion.Slerp harmonise le mouvement
              //  Debug.DrawRay(_magicSpawner.position, _magicSpawner.forward * 5f, Color.red, 2f);
            }

            //if(_hit.point.x > 0) 
            //{
            //  _image.sprite = _avantSprite;

            //    _image.fillAmount -= _filled * Time.deltaTime;

            //    if (_image.fillAmount <= 0.1f)
            //    {
            //        _image.sprite = _avantSprite;
            //    }
            //    _image.fillAmount += _filled * Time.deltaTime;

            //}
            //else
            //{
            //    _image.fillAmount -= _filled *Time.deltaTime;

            //    if (_image.fillAmount <= 0.1f)
            //    {
            //        _image.sprite = _arriereSprite;
            //    }
            //    _image.fillAmount += _filled * Time.deltaTime;

            //}

        }
    }
}
