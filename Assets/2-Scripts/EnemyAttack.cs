using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Transform target;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    bool InFront()
    {
        Vector3 directionToTarget = transform.position- target.position;
        float angle= Vector3.Angle(transform.forward, directionToTarget);
        if(Mathf.Abs(angle) >90 && Mathf.Abs(angle) < 270){
            Debug.DrawLine(transform.position, target.position,Color.green);
            return true;
        }
        Debug.DrawLine(transform.position, target.position,Color.yellow);
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if(target==null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
        
        InFront();
    }
}
