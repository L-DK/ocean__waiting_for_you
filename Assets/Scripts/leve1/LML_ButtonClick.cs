using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LML_ButtonClick : MonoBehaviour
{
    public int index;
    public void ReturnMain()
    {
        SceneManager.LoadScene("leve1");
        Time.timeScale = 1;
        Screen.orientation = ScreenOrientation.Landscape;
    }
}
