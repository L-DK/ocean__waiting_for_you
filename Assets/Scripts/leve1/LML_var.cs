using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_var : MonoBehaviour
{
    #region 静态变量
    public static float CameraWidth;//摄像机宽度
    public static float CameraHeight;//摄像机高度
    public static float bgSpeed;//背景移动速度
    public static float ObsSpeed;//障碍物移动速度
    public static float relSpeed;//存放速度
    public static float relbgSpeed;//存放速度

    #endregion

    #region 非静态变量
    public static float Speed = 1f;//移动速度
    #endregion
    void Start()
    {
        #region 利用计算同步背景、障碍物移动速度
        GetCameraValue();
        ObsSpeed = 0f;
        bgSpeed = 0f;
        //ObsSpeed = (CameraWidth / 5f * 0.02f) * Speed;//同步背景移动和障碍物移动速度
        //bgSpeed = (1f / 5f * 0.02f) * Speed;//同步背景移动和障碍物移动速度
        #endregion
    }


    #region 定义一个获取摄像机宽高的方法
    void GetCameraValue()
    {
        float leftBorder;
        float rightBorder;
        float topBorder;
        float downBorder;

        Vector3 cornerPos = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Mathf.Abs(Camera.main.transform.position.z)));
        leftBorder = Camera.main.transform.position.x - (cornerPos.x - Camera.main.transform.position.x);
        rightBorder = cornerPos.x;
        topBorder = cornerPos.y;
        downBorder = Camera.main.transform.position.y - (cornerPos.y - Camera.main.transform.position.y);
        CameraWidth = rightBorder - leftBorder;
        CameraHeight = topBorder - downBorder;
    }
    #endregion
}
