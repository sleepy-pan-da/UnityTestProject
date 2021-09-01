using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private Vector3 mouseWorldPosition;
    private Vector3 positionToMoveTo;
    private bool isMovingToNewPosition = false;
    
    void Update()
    {
        RotatePlayerToFaceMouseWorldPosition();

        if (Input.GetMouseButtonDown(1))
        {
            isMovingToNewPosition = true;
            positionToMoveTo = GetMouseWorldPosition();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (isMovingToNewPosition)
        {
            MovePlayerToNewPosition();
        }
    }

    private void RotatePlayerToFaceMouseWorldPosition()
    {
        mouseWorldPosition = GetMouseWorldPosition();
        transform.LookAt(mouseWorldPosition);
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.y;
        Vector3 newMouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        
        // prevent player from facing the floor as player is 1 unit in y-axis
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
