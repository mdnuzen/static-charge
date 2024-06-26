﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    //public static ActiveButton activeObj;
    public static MovingPlatforms plat;
    public bool moveOnce;
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    //public GameObject canMove;
    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }


    void Update()
    {
		if(plat == null)
        {
            plat = this;
        }
            MovePlatform();
        
    }

    public bool returnBool()
    {
        return canMove;
    }

   /* // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            MovePlatform();
        }

    }*/

    public void MovePlatform()
    {
         if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
    /*
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }*/
}
