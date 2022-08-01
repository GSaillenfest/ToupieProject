using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] float ballDetectionZone = 5f;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player;

    Rigidbody rb;
    Vector3 ballPos;
    Vector3 playerPos;
    bool isChasingPlayer = true;

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

        if (toBallVector.magnitude > ballDetectionZone) isChasingPlayer = true;
        else if (toBallVector.magnitude <= ballDetectionZone * 0.8f) isChasingPlayer = false;


        if (!isChasingPlayer)
        {
            RunningAway(toBallVector);
        }
        else
        {
            ChasingPlayer(toPlayerVector);
        }
    }

    private void RunningAway(Vector3 toBallVector)
    {
        Quaternion toBallLookRotation = Quaternion.LookRotation(-toBallVector);
        rb.MoveRotation(toBallLookRotation);
        Vector3 toBallVelocity = -speed * toBallVector * (1.2f - toBallVector.magnitude / ballDetectionZone);
        rb.velocity = toBallVelocity;
    }

    private void ChasingPlayer(Vector3 toPlayerVector)
    {
        Quaternion toPlayerLookRotation = Quaternion.LookRotation(toPlayerVector);
        rb.MoveRotation(toPlayerLookRotation);
        Vector3 toPlayerVelocity = speed * toPlayerVector.normalized * 1.2f;
        rb.velocity = toPlayerVelocity;
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
