using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    Vector3 defaultDistance=new Vector3(0f,2f,-10f);
    [SerializeField] Transform target;
    [SerializeField] float distanceDamp = 10f;
    [SerializeField] float rotateDamp = 10f;

    void LateUpdate()
    {
        Vector3 toPos= target.position + ( target.rotation * defaultDistance);
        Vector3 curPos= Vector3.Lerp(transform.position, toPos, distanceDamp* Time.deltaTime);
        transform.position=curPos;
        
        Quaternion toRot= Quaternion.LookRotation( target.position- transform.position, target.up);
        Quaternion curRot= Quaternion.Slerp(transform.rotation, toRot, rotateDamp* Time.deltaTime);
        transform.rotation=curRot;
    }
}
