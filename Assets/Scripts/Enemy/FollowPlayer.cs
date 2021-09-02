using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private GameObject playerReference;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerReference != null)
        {
            Vector3 playerPosition = playerReference.transform.position;
            Vector3 directionOfMovement = (playerPosition - transform.position).normalized;
            Vector3 velocity = directionOfMovement * speed * Time.deltaTime;
            transform.position += velocity;
        }
    }
}
