using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake() and Start() are only called once in the lifetime of a script attached to an object. Cannot repeat calls using enable/disable.


    void Awake()
        // References between scripts, initialization.
        // Awake() is called even if the script component is disabled.
        // Example: Set ammo for the enemy.
    {
        Debug.Log("Awake called.");
    }

    // Start is called before the first frame update
    void Start()
        // Only called if script component is enabled.
        // Start() is called ONCE if a script compopent is enabled any time while running.
        // Example: Allow enemy to shoot.
    {
        Debug.Log("Start called.");
    }
}
