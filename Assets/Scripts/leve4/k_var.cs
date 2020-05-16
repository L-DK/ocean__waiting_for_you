using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class k_var : MonoBehaviour
{
    #region 静态变量
    public static float CameraWidth;//摄像机宽度
    public static float CameraHeight;//摄像机高度
    public static float bgSpeed;//背景移动速度
    public static float ObsSpeed;//障碍物移动速度
    public static float PropSpeed;//道具移动速度
    public static Vector2 pathUp_pos;//路径上位置
    public static Vector2 pathMiddle_pos;//路径中位置
    public static Vector2 pathDown_pos;//路径下位置
    public static bool isgameover = false;
    public static bool iswin = false;


    #endregion

    public Text money1Txt;
    public Text money2Txt;

    public static int score;//第三章分数
    public static int tar_score;//目标分数
    public Text sc;//第四章分数文本
    public Text tar;//第四章目标分数文本
    public Text gq;//关卡文本
    public int get_money1;
    public int get_money2;
    #region 非静态变量
    public GameObject pathUp;//路径上
    public GameObject pathMiddle;//路径中
    public GameObject pathDown;//路径下
    public float Speed = 2f;//移动速度

    #endregion
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
        Screen.orientation = ScreenOrientation.Landscape;
    }
    void Start()

    {
        isgameover = false;
        iswin = false;
        money1Txt.gameObject.SetActive(false);
        money2Txt.gameObject.SetActive(false);

        gq.text = "第3章  关卡" + varDate.Go_Level_child;
        switch (varDate.Go_Level_child)
        {
            case 1:
                tar_score = 30;
                break;
            case 2:
                tar_score = 60;
                break;
            case 3:
                tar_score = 90;
                break;
            case 4:
                tar_score = 120;
                break;
            case 5:
                tar_score = 150;
                break;

            default:
                break;
        }
        tar.text = "目标：" + tar_score;
        score = 0;


        #region 三条路径
        pathUp_pos = pathUp.transform.position;
        pathMiddle_pos = pathMiddle.transform.position;
        pathDown_pos = pathDown.transform.position;
        #endregion
    }
    private void Update()
    {
        #region 利用计算同步背景、障碍物移动速度
        GetCameraValue();
        ObsSpeed = (CameraWidth / 5f * 0.02f) * Speed;//同步背景移动和障碍物移动速度
        PropSpeed = (CameraWidth / 5f * 0.02f) * Speed;//同步背景移动和障碍物移动速度
        bgSpeed = (1f / 5f * 0.02f) * Speed;//同步背景移动和障碍物移动速度
        #endregion
        if (isgameover)
        {
            Time.timeScale = 0;
            Speed = 0;


        }
        else
        {
            Time.timeScale = 1;
            Speed = 2;
        }

        sc.text = "得分：" + score;
        if (score >= tar_score)
        {
            isgameover = true;
            iswin = true;
        }
        if (isgameover)
        {
            get_money1 = score;//最终获得的珍珠
            get_money2 = (int)Mathf.Floor(score * 0.1f);//最终获得的珊瑚
            money1Txt.text = "" + get_money1;
            money2Txt.text = "" + get_money2;//获取珊瑚数量等0.1的珍珠

            money1Txt.gameObject.SetActive(true);
            money2Txt.gameObject.SetActive(true);
            varDate.money1 += get_money1;
            varDate.money2 += get_money2;
        }
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
