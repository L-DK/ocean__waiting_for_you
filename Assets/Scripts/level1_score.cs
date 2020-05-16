using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1_score : MonoBehaviour
{
    public GameObject _player;
    public static int curDistance;
    public static bool isgameover = false;
    public static bool iswin = false;
    public static int score = 0;
    public static int tar_score;//目标分数
    public GameObject win;
    public GameObject lose;
    public Text sc;//第1章分数文本
    public Text jvli;//距离
    public Text tar;//第1章目标分数文本
    public Text gq;//关卡文本
    public Text money1Txt;
    public Text money2Txt;
    public int get_money1;
    public int get_money2;

    private void Awake()
    {
        iswin = false;
        isgameover = false;
        win.SetActive(false);
        lose.SetActive(false);
    }
    private void Start()
    {
        score = 0;

        money1Txt.gameObject.SetActive(false);
        money2Txt.gameObject.SetActive(false);
        gq.text = "第1章  关卡" + varDate.Go_Level_child;
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


        jvli.text = "距离：" + (int)_player.transform.position.y;

        sc.text = "得分：" + score;
        if ((int)_player.transform.position.y >= tar_score)
        {
            isgameover = true;
            iswin = true;
        }
        if (isgameover)
        {


            Time.timeScale = 0;


            if (iswin)
            {
                win.SetActive(true);
            }
            else
            {
                lose.SetActive(true);
            }

            get_money1 = score + (int)_player.transform.position.y;//最终获得的珍珠
            get_money2 = (int)Mathf.Floor(get_money1 * 0.1f);//最终获得的珊瑚
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
    public void back_main()
    {
        SceneManager.LoadScene("Main");

    }
    public void to_leve1()
    {
        SceneManager.LoadScene("leve1");
        win.SetActive(false);
        lose.SetActive(false);

    }
    public void to_Select_child()
    {
        SceneManager.LoadScene("Select_child");

    }
}
