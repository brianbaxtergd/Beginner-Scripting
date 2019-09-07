using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    void Start()
    {
        // Value type variable.
        //Vector3 currentPosition = transform.position;
        //currentPosition = new Vector3(0, 2, 0);

        // Reference type variable.
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
