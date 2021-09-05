using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCuboid : MonoBehaviour
{
    [SerializeField]
    private Material materialToChangeToOnTriggerEnter;
  

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().material = materialToChangeToOnTriggerEnter;
    }
}
