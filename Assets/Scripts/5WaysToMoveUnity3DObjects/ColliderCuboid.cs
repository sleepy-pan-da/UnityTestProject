using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCuboid : MonoBehaviour
{
    [SerializeField]
    private Material materialToChangeToOnCollisionEnter;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material = materialToChangeToOnCollisionEnter;
    }
}
