using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _torque = 500f;

    Vector3 movementInput;
    Vector3 orientationInput;
    float _orientationHorizontal;

    Rigidbody _rigibody;

    private void Awake()
    {
       _rigibody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        _rigibody.rotation = Quaternion.identity;
    }

    void Update()
    {
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");
        movementInput = new Vector3(_horizontal, 0f, _vertical);

        _orientationHorizontal = Input.GetAxisRaw("OrientationHorizontal");

        //float _orientationVertical = Input.GetAxisRaw("OrientationVertical");
        //if (_orientationHorizontal != 0 && _orientationVertical != 0) orientationInput = new Vector3(_orientationHorizontal, 0f, _orientationVertical).normalized;
        //else return;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = _speed * movementInput;
        _rigibody.velocity = velocity;
        //Quaternion lookRotation = Quaternion.LookRotation(orientationInput);
        _rigibody.AddTorque(new Vector3(0, _torque * _orientationHorizontal, 0));

    }
}
