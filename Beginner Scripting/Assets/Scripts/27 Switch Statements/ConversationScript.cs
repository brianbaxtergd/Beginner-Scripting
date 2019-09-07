using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;


    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("4");
                break;
            case 3:
                print("3");
                break;
            case 2:
                print("2");
                break;
            case 1:
                print("1");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}
