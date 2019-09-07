using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float updateTimer;


    // ctrl + shift + M: Open MonoBehavior Scripting Wizard.

    void FixedUpdate()
        // Called every physics step.
        // FixedUpdate intervals are consistent.
        // Used for regular updates such as:
        //  Adjusting physics (Rigidbody) objects.
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    void Update()
        // Called every frame.
        // Used for regular updates such as:
        //  Moving non-physics objects.
        //  Simple timers.
        //  Receiving input.

        // Update interval times vary.
    {
        Debug.Log("Update time: " + Time.deltaTime);
    }
}
