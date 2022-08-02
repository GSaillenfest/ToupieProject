using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] float playerDetectionRange = 5f;
    [SerializeField] GameObject ball;
    [SerializeField] int index;

    Rigidbody rb;
    Vector3 playerPos;
    bool isChasingPlayer = true;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 toPlayerVector = playerPos - transform.position;

        if (toPlayerVector.magnitude > playerDetectionRange) isChasingPlayer = true;
        else if (toPlayerVector.magnitude <= playerDetectionRange * 0.7f && player.GetComponent<TwinstickMovement>().index == index) isChasingPlayer = false;


        if (!isChasingPlayer)
        {
            RunningAway(toPlayerVector);
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
        Vector3 toBallVelocity = -speed * toBallVector * (1.2f - toBallVector.magnitude / playerDetectionRange);
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
