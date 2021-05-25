using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float movementSpeed=50f;
    [SerializeField] float turnSpeed=60f;

    void Update(){
        Turn();
        Thrust();
    }

    void Thrust(){
        if(Input.GetAxis("Vertical")>0)
            transform.position += transform.forward* movementSpeed* Time.deltaTime* Input.GetAxis("Vertical");
    }

    void Turn(){
        float yaw= turnSpeed* Time.deltaTime* Input.GetAxis("Horizontal");
        float pitch= turnSpeed* Time.deltaTime* Input.GetAxis("Pitch");
        float roll= turnSpeed* Time.deltaTime* Input.GetAxis("Roll");

        transform.Rotate(pitch,yaw,-roll);
    }

}
