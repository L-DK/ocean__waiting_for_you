using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class k_score_leve5 : MonoBehaviour
{
    public static int score;//第三章分数
    public static int tar_score;//目标分数
    public Text sc;//第三章分数文本
    public Text tar;//第三章目标分数文本
    public Text gq;//关卡文本
    public static bool isgameover = false;
    public static bool iswin = false;
    public Text money1Txt;
    public Text money2Txt;
    public int get_money1;
    public int get_money2;


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

    }

    void Update()
    {


        sc.text = "得分：" + score;
        if (score >= tar_score)
        {
            isgameover = true;
            iswin = true;
        }
        if (isgameover)
        {
            Time.timeScale = 0;
            get_money1 = score;//最终获得的珍珠
            get_money2 = (int)Mathf.Floor(score * 0.1f);//最终获得的珊瑚
            money1Txt.text = "" + get_money1;

            money2Txt.text = "" + get_money2;//获取珊瑚数量等0.1的珍珠

            money1Txt.gameObject.SetActive(true);
            money2Txt.gameObject.SetActive(true);

        }
        else
        {
            Time.timeScale = 1;
        }

    }
}
