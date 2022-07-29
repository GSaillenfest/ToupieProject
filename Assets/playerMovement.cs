using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _torque = 500f;
    [SerializeField] float boundary = 9f;
    [SerializeField] GameObject[] projectiles;

    Vector3 movementInput;
    float _orientationHorizontal;
    bool fire = false;

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
        movementInput = new Vector3(_horizontal, 0f, _vertical).normalized;

        _orientationHorizontal = Input.GetAxisRaw("OrientationHorizontal");

        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -boundary, boundary),
        1f,
        Mathf.Clamp(transform.position.z, -boundary, boundary));

        //if (Input.GetButton("Fire1"))
        //{
        //    fire = !fire;
        //}

        //if (fire)
        //{
        //    int index = Random.Range(0, 3);
        //    Instantiate(projectiles[index], transform.position + new Vector3(0, 0, 2f), Quaternion.identity);
        //}
    }
    private void FixedUpdate()
    {
        Vector3 velocity = _speed * movementInput;
        _rigibody.velocity = velocity;
        _rigibody.AddTorque(new Vector3(0f, _torque * _orientationHorizontal, 0f), ForceMode.VelocityChange);

        if (Mathf.Abs(transform.localRotation.x) > 2f || Mathf.Abs(transform.localRotation.z) > 2f)
        {
            _rigibody.MoveRotation(Quaternion.Euler(0f, transform.rotation.y, 0f));
            Debug.Log("correction de la rotation");
        }
    }
}
