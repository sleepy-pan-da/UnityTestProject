using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PullTrigger();
        }
    }

    private void PullTrigger()
    {
        Vector3 offset = transform.forward * (float)1.25;
        Vector3 bulletSpawnPosition = transform.position + offset;
        Instantiate(bulletPrefab, bulletSpawnPosition, transform.rotation);

    }

}
