﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        // This line is there to tell me the X position of my object.

        /* Hi there!
         * This is two lines!
         * */
        Debug.Log(transform.position.x);

        /*
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to the hit the ground!");
        }
        */
    }
}
