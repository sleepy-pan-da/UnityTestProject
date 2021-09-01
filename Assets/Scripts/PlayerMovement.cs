using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private Vector3 mouseWorldPosition;
    private Vector3 positionToMoveTo;
    private bool isMovingToNewPosition = false;

    void Start()
    {
        
    }

    void Update()
    {
        RotatePlayerToFaceMouseWorldPosition();

        if (Input.GetMouseButtonDown(1))
        {
            isMovingToNewPosition = true;
            positionToMoveTo = GetMouseWorldPosition();
        }

        if (isMovingToNewPosition)
        {
            MovePlayerToNewPosition();
        }

        //if (Vector3.Distance(transform.position, worldPosition) >= 5)
        //{
        //    Vector3 directionOfMovement = (worldPosition - transform.position).normalized;
        //    Vector3 velocity = directionOfMovement * speed * Time.deltaTime;
        //    transform.position += velocity;
        //}
    }

    private void RotatePlayerToFaceMouseWorldPosition()
    {
        mouseWorldPosition = GetMouseWorldPosition();
        transform.LookAt(mouseWorldPosition);
        print(mouseWorldPosition);
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.y;
        Vector3 newMouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        
        // prevent player from facing the floor as player is 1unit in y-axis
        newMouseWorldPosition.y = transform.position.y;
        return newMouseWorldPosition;
    }

    private void MovePlayerToNewPosition()
    {
        if (Vector3.Distance(transform.position, positionToMoveTo) >= 0.5)
        {
            Vector3 directionOfMovement = (positionToMoveTo - transform.position).normalized;
            Vector3 velocity = directionOfMovement * speed * Time.deltaTime;
            transform.position += velocity;
        }
        else isMovingToNewPosition = false;
    }

}