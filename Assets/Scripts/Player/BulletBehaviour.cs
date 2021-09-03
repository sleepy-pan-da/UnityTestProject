using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody bulletRigidBody;
    [SerializeField]
    private float forceMultiplier;

    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        bulletRigidBody.velocity = transform.forward * forceMultiplier;
        //bulletRigidBody.AddForce(transform.forward * forceMultiplier, ForceMode.VelocityChange);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
