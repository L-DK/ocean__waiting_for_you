using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_var : MonoBehaviour
{

    public static bool isGameOver = false;
    public static bool music_b1 = false;
    public static bool music_b2 = false;
    public static bool music_b3 = false;

    //public  bool isGameOver = false;

    public static bool isgameover = false;
    public static bool iswin = false;
 
    public static implicit operator ball_var(int v)
    {
        throw new NotImplementedException();
    }
}
