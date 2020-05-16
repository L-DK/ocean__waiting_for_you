using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_ctrl : MonoBehaviour
{

    public GameObject set_jc;
    public GameObject set_hz;

    public void clear_data() {
        Debug.Log("清楚数据");
        PlayerPrefs.DeleteAll();
    }
    public void sey_jc_click()
    {
        set_jc.SetActive(true);
        set_hz.SetActive(false);

    }
    public void sey_hz_click()
    {
        set_jc.SetActive(false);
        set_hz.SetActive(true);

    }
    public void To_Challenge()
    {

        SceneManager.LoadScene("Challenge");

    }

    public void To_details()
    {
        varDate.ShopOrRole = 1;

        SceneManager.LoadScene("roledetails");
    }

    public GameObject ChallengeTxt;
    public void Challenge_to_leve1()
    {
        if (false)
        {
            SceneManager.LoadScene("leve1");
        }
        else
        {
            ChallengeTxt.SetActive(true);
        }
    }
    public void Challenge_to_leve2()
    {
        if (false)
        {
            SceneManager.LoadScene("leve2");
        }
        else
        {
            ChallengeTxt.SetActive(true);
        }
    }
    public void Challenge_to_leve3()
    {
        if (false)
        {
            SceneManager.LoadScene("leve3");
        }
        else
        {
            ChallengeTxt.SetActive(true);
        }
    }
    public void Challenge_to_leve4()
    {
        if (false)
        {
            SceneManager.LoadScene("leve4");
        }
        else
        {
            ChallengeTxt.SetActive(true);
        }
    }

    public void To_Select()
    {

        SceneManager.LoadScene("Select");

    }


    public void To_Set()
    {

        SceneManager.LoadScene("Set");

    }
    public void To_shop()
    {
        varDate.ShopOrRole = 0;

        SceneManager.LoadScene("Shop");
        Debug.Log(varDate.ShopOrRole);
    }
    public void To_Answer()
    {

        SceneManager.LoadScene("answer");

        demo.index = 0;//数组下标
        demo.score = 0;//初始分数
        demo.level = 1;//初始关卡
        demo.hP = 2;
        demo.proLevel = 1;
        L_Problems.trueNum = 0;

    }


    /// <summary>
    /// 角色返回主页
    /// </summary>
    public void To_Main()
    {

        SceneManager.LoadScene("Main");

    }
    public void To_level1()
    {

        SceneManager.LoadScene("leve1");

    }

    #region 进入小关选择
    public void Select_to_1()
    {
        varDate.Go_Level = 1;
        Debug.Log("大关卡" + varDate.Go_Level);
        SceneManager.LoadScene("Select_child");

    }
    public void Select_to_2()
    {
        varDate.Go_Level = 2;
        Debug.Log("大关卡" + varDate.Go_Level);
        SceneManager.LoadScene("Select_child");
    }
    public void Select_to_3()
    {
        varDate.Go_Level = 3;
        Debug.Log("大关卡" + varDate.Go_Level);
        SceneManager.LoadScene("Select_child");
    }
    public void Select_to_4()
    {
        varDate.Go_Level = 4;
        Debug.Log("大关卡"+varDate.Go_Level);
        SceneManager.LoadScene("Select_child");
    }
    #endregion

    #region 进入游戏
    public void Select_to_leve1()
    {
        varDate.Go_Level_child = 1;
        SceneManager.LoadScene("Select_Role");
    }
    public void Select_to_leve2()
    {
        varDate.Go_Level_child = 2;
        SceneManager.LoadScene("Select_Role");
    }
    public void Select_to_leve3()
    {
        varDate.Go_Level_child = 3;
        SceneManager.LoadScene("Select_Role");
    }
    public void Select_to_leve4()
    {
        varDate.Go_Level_child = 4;
        SceneManager.LoadScene("Select_Role");
    }
    #endregion




}
