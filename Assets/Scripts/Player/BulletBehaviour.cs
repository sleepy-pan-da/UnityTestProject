using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody bulletRigidBody;
    [SerializeField]
    private float speedMultiplier;

    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        bulletRigidBody.velocity = transform.forward * speedMultiplier;
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
