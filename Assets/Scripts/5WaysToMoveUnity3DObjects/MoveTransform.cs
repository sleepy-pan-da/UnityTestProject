using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime;
    }
}
