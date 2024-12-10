using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetFlashlight : MonoBehaviour
{

    private Vector3 _vectorOffset;
    private GameObject _goFollow;

    [SerializeField] private float _speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        _goFollow = Camera.main.gameObject;
        _vectorOffset = transform.position - _goFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _goFollow.transform.position + _vectorOffset;
        transform.rotation = Quaternion.Slerp(transform.rotation, _goFollow.transform.rotation, _speed * Time.deltaTime);
    }
}
