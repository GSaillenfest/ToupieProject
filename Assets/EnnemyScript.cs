using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] float ballDetectionZone = 5f;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;

    Rigidbody rb;
    Vector3 ballPos;
    Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ballPos = ball.transform.position;
        playerPos = player.transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 toPlayerVector = playerPos - transform.position;
        Vector3 toBallVector = ballPos - transform.position;
        rb.velocity = Vector3.forward * speed;
        if (toBallVector.magnitude <= ballDetectionZone)
        {
            Quaternion toBallLookRotation = Quaternion.LookRotation(-toBallVector);
            rb.MoveRotation(toBallLookRotation);
            Vector3 toBallVelocity = -speed * toBallVector * (1 - toBallVector.magnitude / (ballDetectionZone));
            rb.velocity = toBallVelocity;
        }
        else
        {
            Debug.Log("chasing player");
            Quaternion toPlayerLookRotation = Quaternion.LookRotation(toPlayerVector);
            rb.MoveRotation(toPlayerLookRotation);
            Vector3 toPlayerVelocity = speed * toPlayerVector.normalized * 1.2f;
            rb.velocity = toPlayerVelocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(ball.gameObject.tag))
        {
            Destroy(ball);
            Destroy(gameObject);
        }
    }
}
