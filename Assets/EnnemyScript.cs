using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    Rigidbody rb;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        playerPosition = FindObjectOfType<playerMovement>().transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 orientation = playerPosition - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(orientation);
        rb.MoveRotation(lookRotation);
        Vector3 velocity = speed * orientation.normalized;
        rb.velocity = velocity;
    }
}
