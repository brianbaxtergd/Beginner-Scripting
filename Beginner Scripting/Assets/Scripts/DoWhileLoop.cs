using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            // Body of doWhile loop is guaranteed to run at least once.
            print("Hello World");
        }
        while (shouldContinue == true); // Note semicolon at end of doWhile loop.
    }
}
