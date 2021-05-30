using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameManager : MonoBehaviour
{
    public GameObject Explotion;
    public GameObject Explotion2;

    private void Start()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Raycast();
        }
    }

    public void Raycast()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            if (objectHit.CompareTag("Enemy"))
            {
                Instantiate(Explotion, objectHit.transform.position, Quaternion.identity).transform.localScale = objectHit.transform.localScale;
                Destroy(objectHit.gameObject);
                ScoreManager.Instance.IncScore(10);
            }
            else if(objectHit.CompareTag("Ast"))
            {
                Instantiate(Explotion2, objectHit.transform.position, Quaternion.identity).transform.localScale = objectHit.transform.localScale;
                Destroy(objectHit.gameObject);
                ScoreManager.Instance.IncScore(5);
            }
        }
        else
        {
            print("vuramadın");
        }
    }
}
