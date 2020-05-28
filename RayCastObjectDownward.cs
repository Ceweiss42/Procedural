﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.Runtime.InteropServices;
using UnityEngine;

public class RayCastObjectDownward : MonoBehaviour
{

    public RaycastHit hit;
    public GameObject legTarget;
    public string name;
    


    void Start()
    { //this was explained in the other code file, but the GetComponent<GameObject>() method was not saving the objects for some reason
        legTarget = GameObject.Find(name);
       
    }
    void Update()
    {
        //draw ray from top down
        Debug.DrawRay(transform.position, Vector3.down * 10f, Color.green);
        
        //if it hits the ground, move the target to the point where it hit
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 10f, 1))
        {
            legTarget.transform.position = hit.point;
        }
        else
        {
            Debug.Log("Nothing there");
        }

    }
}

