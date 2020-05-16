using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKY : MonoBehaviour
{


    public Material yellow;
    public Material blue;
    public Material purple;
    public static bool isyellow;
    public static bool isblue;
    public static bool ispurple;
    void Start()
    {

        rSyk();
    }
    public static void rSyk()
    {
        int r = 1;
        switch (r)
        {
            case 0:
                {
                    isyellow = true;
                    isblue = false;
                    ispurple = false;
                }
                break;
            case 1:
                {
                    isyellow = false;
                    isblue = true;
                    ispurple = false;
                }
                break;
            case 2:
                {
                    isyellow = false;
                    isblue = false;
                    ispurple = true;
                }
                break;
        }
    }


    void Update()
    {

      


        if (isyellow)
        {
            RenderSettings.skybox = yellow;
        }
        if (isblue)
        {
            RenderSettings.skybox = blue;
        }
        if (ispurple)
        {
            RenderSettings.skybox = purple;
        }

    }
}
