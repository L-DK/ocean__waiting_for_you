using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_BackgroundMove : MonoBehaviour
{

    Renderer rend;//定义Renderer组件
    Vector2 oldOffset;//定义场景偏移量
    public GameObject Role;
    public static bool IsStart = false;//判断空格是否按下
    public static float Roley;
    public static float speedMove = 0.04f;//角色向前移动速度
    public float x;
    public GameObject startPlane;

    void Start()
    {
        LML_LitterFall.isCreat1 = false;
        startPlane.SetActive(true);
        rend = this.GetComponent<Renderer>();//获取Renderer组件
        LML_var.Speed = 1;//1
                          //LML_var.bgSpeed = 0;
        speedMove = 0.04f;//0.04f
    }

    void Update()
    {

        if (level1_score.isgameover)
        {
            LML_var.Speed = 0;//1
            LML_var.bgSpeed = 0;
            speedMove = 0;//0.04f

        }
        else
        {
            LML_var.Speed = 1;//1
            LML_var.bgSpeed = 0;
            speedMove = 0.04f;//0.04f
        }



        Roley = Role.transform.position.y;
        x = Role.transform.position.x;
        //按下空格键 背景和角色向前移动
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsStart = true;
            LML_LitterFall.isCreat1 = true;
            startPlane.SetActive(false);
        }
        if (Input.touchCount == 1)
        {
            IsStart = true;
            LML_LitterFall.isCreat1 = true;
            startPlane.SetActive(false);

        }

        if (IsStart)
        {
            LML_var.ObsSpeed = (LML_var.CameraWidth / 5f * 0.02f) * LML_var.Speed;//同步背景移动和障碍物移动速度
            LML_var.bgSpeed = (1f / 5f * 0.02f) * LML_var.Speed;//同步背景移动和障碍物移动速度
            Role.transform.position = new Vector2(x, Roley + speedMove);
        }
        oldOffset = rend.material.mainTextureOffset;//获取偏移量
        float y = oldOffset.y;//获取Y轴偏移量
        rend.material.mainTextureOffset = new Vector2(0, y + LML_var.bgSpeed);//偏移speed


    }
}
