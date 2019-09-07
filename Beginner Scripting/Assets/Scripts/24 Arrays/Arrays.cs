using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //int[] myIntArray = new int[5];
    //int[] myIntArray = { 12, 76, 8, 937, 903 };

    public GameObject[] players;


    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
    }
}
