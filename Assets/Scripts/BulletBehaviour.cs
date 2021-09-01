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
        bulletRigidBody.AddForce(transform.forward * forceMultiplier, ForceMode.Impulse);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy when hit enemy
    }
}
