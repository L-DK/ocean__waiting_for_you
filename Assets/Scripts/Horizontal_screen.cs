using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal_screen : MonoBehaviour {

    //横屏
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
        Screen.orientation = ScreenOrientation.Landscape;
    }
}
