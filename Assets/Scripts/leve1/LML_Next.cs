using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LML_Next : MonoBehaviour
{

    //进入下一关
    public void next()
    {
        //LML_demo.level++;
        //LML_demo.index++;
        SceneManager.LoadScene("leve1");
        //LML_BackgroundMove.speedMove += 0.01f;
        //LML_Fall.speed += 0.01f;
        //LML_Fall.speed1 += 0.01f;
        //LML_LitterFall.Sappear_time -= 0.2f;
        //LML_LitterFall.Dappear_time -= 0.2f;
    }
}
