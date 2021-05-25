using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Vector3 randomRotation;
    [SerializeField] float minScale=0.8f;
    [SerializeField] float maxScale=1.2f;
    [SerializeField] float rotationOffset=50f;

    void Start()
    {
        Vector3 scale=Vector3.one;
        scale.x= Random.Range(minScale, maxScale);
        scale.y= Random.Range(minScale, maxScale);
        scale.z= Random.Range(minScale, maxScale);
        transform.localScale=scale;

        randomRotation.x= Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y= Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z= Random.Range(-rotationOffset, rotationOffset);
    }

    void Update()
    {
        transform.Rotate(randomRotation * Time.deltaTime);
    }
}
