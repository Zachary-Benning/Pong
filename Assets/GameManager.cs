using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    // This is where score keeping and winning objectives would be stored.
    public static int Left_Player = 0;
    public static int Right_Player = 0;

    GameObject theBall;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }
    
    public static void Score(string wallID)
    {
        if (wallID == "RightWall")
        {
            Left_Player++;
        }
        else
        {
            Right_Player++;
        }
    }
    
}