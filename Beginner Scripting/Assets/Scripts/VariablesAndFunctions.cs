using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        myInt = MultipliedByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultipliedByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
