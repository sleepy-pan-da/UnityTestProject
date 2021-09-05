using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime);
    }
}
