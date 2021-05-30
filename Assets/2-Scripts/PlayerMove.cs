using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float movementSpeed=50f;
    [SerializeField] float turnSpeed=60f;

    [SerializeField] private GameObject _fireObject;
    
    void Update(){
        Turn();
        Thrust();
    }

    void Thrust()
    {
        float pitch = 0;
        
        if (Input.GetKey(KeyCode.F))
        {
            pitch = .7f;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            pitch = -.7f;
        }

        float yaw = 0;
        
        if (Input.GetKey(KeyCode.D))
        {
            yaw = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            yaw = -1;
        }

        float roll = 0;
        
        if (Input.GetKey(KeyCode.E))
        {
            roll = 1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            roll = -1;
        }

        
        transform.Rotate(pitch,yaw,-roll);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            _fireObject.SetActive(true);
        }
        else
        {
            _fireObject.SetActive(false);
        }
    }

    void Turn(){
        //float yaw= turnSpeed* Time.deltaTime* Input.GetAxis("Horizontal");
        //float pitch= turnSpeed* Time.deltaTime* Input.GetAxis("Pitch");
        //float roll= turnSpeed* Time.deltaTime* Input.GetAxis("Roll");

        //transform.Rotate(pitch,yaw,-roll);
    }

}
