using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform firePosition;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, firePosition.position, firePosition.rotation) as Rigidbody;
            projectileInstance.AddForce(firePosition.forward * 350f);
        }    
    }
}
