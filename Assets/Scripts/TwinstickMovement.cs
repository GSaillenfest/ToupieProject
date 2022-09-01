using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinstickMovement : MonoBehaviour
{
    [SerializeField] Rigidbody playerRb;
    [SerializeField] GameObject[] projectile;
    [SerializeField] Material[] topMat;
    [SerializeField] float _speed = 5f;
    [SerializeField] float boundary = 9f;
    [SerializeField] float projectileForce = 10f;
    [SerializeField] float fireRate = 0.2f;
    [SerializeField] GameObject shootPointLeft;
    [SerializeField] GameObject shootPointRight;
    [SerializeField] Animator rightCannon;
    [SerializeField] Animator leftCannon;

    Vector3 movementInput;
    Vector3 orientation;
    float _orientationHorizontal;
    float _orientationVertical;
    float nextShotTime;
    GameObject shootPoint;
    public int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        shootPoint = shootPointLeft;
        nextShotTime = Time.time;
        gameObject.GetComponentInChildren<MeshRenderer>().material = topMat[index];

    }

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");
        movementInput = new Vector3(_horizontal, 0f, _vertical).normalized;

        _orientationHorizontal = Input.GetAxisRaw("OrientationHorizontal");
        _orientationVertical = Input.GetAxisRaw("OrientationVertical");

        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -boundary, boundary),
        transform.position.y,
        Mathf.Clamp(transform.position.z, -boundary, boundary));

        if (_orientationVertical != 0 || _orientationHorizontal != 0) orientation = new Vector3(_orientationHorizontal, 0, _orientationVertical);

        if (Input.GetButton("Fire1") || Input.GetAxis("Fire1") != 0)
        {
            if (Time.time >= nextShotTime)
            {
                if (shootPoint == shootPointLeft)
                {
                    shootPoint = shootPointRight;
                    rightCannon.SetTrigger("fire");
                }
                else
                {
                    shootPoint = shootPointLeft;
                    leftCannon.SetTrigger("fire");
                }
                Fire();
            }
        }

    }

    private void FixedUpdate()
    {
        Vector3 velocity = _speed * movementInput;
        playerRb.velocity = velocity;
        Quaternion lookRotation = Quaternion.LookRotation(orientation);
        playerRb.MoveRotation(lookRotation);
    }

    void Fire()
    {
        GameObject newProjectile = Instantiate(projectile[index], shootPoint.transform.position, transform.rotation);
        newProjectile.GetComponent<Projectile>().Shoot(projectileForce);
        Destroy(newProjectile, 5f);
        nextShotTime = Time.time + fireRate;
    }

    void ChangeBullet(int index)
    {
        gameObject.GetComponentInChildren<MeshRenderer>().material = topMat[index];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("yellowBall")) index = 0;
        else if (other.gameObject.CompareTag("greenBall")) index = 1;
        else if (other.gameObject.CompareTag("blueBall")) index = 2;
        ChangeBullet(index);
    }
}
