using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Vector3 randomRotation;
    [SerializeField] float rotationOffset=50f;

    void Start()
    {
        Vector3 scale = Vector3.one;
        
        var rand = Random.Range(0f, 1f);

        if (rand < .03f)
        {
            scale *= Random.Range(15, 23);
        }
        else if (rand < .5)
        {
            scale *= Random.Range(2, 5);
        }
        
        
        
        
        
        
        transform.localScale=scale;

        randomRotation.x= Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y= Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z= Random.Range(-rotationOffset, rotationOffset);

        randomRotation /= (scale.x/3f);
        
        transform.Rotate(randomRotation * Time.deltaTime);
    }

    void Update()
    {
        transform.Rotate(randomRotation * Time.deltaTime);
    }
}
