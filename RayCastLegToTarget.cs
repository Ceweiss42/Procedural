using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastLegToTarget : MonoBehaviour
{
    //this is the raycasted target
    public GameObject legGrounded;

    public RaycastHit hit;

    //this is the name of the raycasted target, I was having problems with the GetComponent<GameObject>() method for some reason and I just bypassed it with the name.
    public string name;

    //the distance from leg to raycasted target
    public double distance;

    //tells the leg whene to move
    public bool needToMove = false;


    // Start is called before the first frame update
    void Start()
    {
        legGrounded = GameObject.Find(name);
        distance = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //dray the Ray from leg to raycasted target, easy to see in editor
        Debug.DrawRay(legGrounded.transform.position, (this.transform.position - legGrounded.transform.position), Color.red);

        //3D pythagorean theroem to calculate distance from raycasted target to leg
        double dX = legGrounded.transform.position.x - this.transform.position.x;
        double dY = legGrounded.transform.position.y - this.transform.position.y;
        double dZ = legGrounded.transform.position.z - this.transform.position.z;

        distance = Math.Sqrt((dX * dX) + (dY * dY) + (dZ * dZ));

        if(distance >= 1f)
        {
            Debug.Log("Need to move the leg");
            needToMove = true;
            
        }

        //the 7f is the speed of movement
        if (needToMove)
        {
            //move the leg!!!!
          this.transform.position = Vector3.MoveTowards(this.transform.position, legGrounded.transform.position, 7f * Time.deltaTime);
        }

        if(distance <= 0.05)
        { //turn of the need to move
            needToMove = false;
        }

    }
}
