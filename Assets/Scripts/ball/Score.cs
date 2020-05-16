using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    public static int score = 0;
    public static bool change = true;

    public static int Maxscore;

    public static int tar_score;//目标分数
    public Text sc;//第三章分数文本
    public Text tar;//第三章目标分数文本
    public Text gq;//关卡文本
    public Text money1Txt;
    public Text money2Txt;
    public int get_money1;
    public int get_money2;

    private void Start()
    {
        ball_var.isGameOver = false;
        ball_var.iswin = false;
        money1Txt.gameObject.SetActive(false);
        money2Txt.gameObject.SetActive(false);
        gq.text = "第2章  关卡" + varDate.Go_Level_child;
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
            ball_var.isgameover = true;
            ball_var.iswin = true;
        }
        if (ball_var.isgameover)
        {
            Time.timeScale = 0;
            get_money1 = score;//最终获得的珍珠
            get_money2 = (int)Mathf.Floor(score * 0.1f);//最终获得的珊瑚
            money1Txt.text = "" + get_money1;
            money2Txt.text = "" + get_money2;//获取珊瑚数量等0.1的珍珠
            money1Txt.gameObject.SetActive(true);
            money2Txt.gameObject.SetActive(true);
            varDate.money1 += get_money1;
            varDate.money2 += get_money2;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

}
