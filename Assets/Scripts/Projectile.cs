using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] Rigidbody projectileRb;
    [SerializeField] ParticleSystem particlePrefab;
    float projectileForce;

    private void Awake()
    {
        ParticleSystem fireBurst = Instantiate(particlePrefab, transform.position, transform.rotation);
        Destroy(fireBurst, 1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        projectileRb.AddForce(transform.forward * projectileForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Vector3 velocity = transform.forward * projectileSpeed;
        //Vector3 movementStep = velocity * Time.fixedDeltaTime;
        //Vector3 newPos = movementStep + transform.position;
        //projectileRb.MovePosition(newPos);
    }

    public void Shoot(float force)
    {
        projectileForce = force;
        Debug.Log(force);
    }
}
