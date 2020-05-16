using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money_Data : MonoBehaviour
{

    public Text money1_txt;
    public Text money2_txt;

    //是否写入
    void Start()
    {


        //重置

        //PlayerPrefs.SetString("UseMoney1", varDate.money1.ToString());
        //PlayerPrefs.SetString("UseMoney2", varDate.money2.ToString());

        //varDate.money1 = int.Parse(PlayerPrefs.GetString("UseMoney1"));
        //varDate.money2 = int.Parse(PlayerPrefs.GetString("UseMoney2"));

        //PlayerPrefs.DeleteAll();

    }

    #region 加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加
    private void Update()
    {
        //无限
        if (PlayerPrefs.GetInt("UseMoney1") == 0 || PlayerPrefs.GetInt("UseMoney2") == 0)
        {
            PlayerPrefs.SetInt("UseMoney1", 99999);
            PlayerPrefs.SetInt("UseMoney2", 99999);
        }
        //读取珍珠珊瑚数
        money1_txt.text = PlayerPrefs.GetInt("UseMoney1").ToString();
        money2_txt.text = PlayerPrefs.GetInt("UseMoney2").ToString();
        Debug.Log("珍珠" + PlayerPrefs.GetInt("UseMoney1") + "珊瑚" + PlayerPrefs.GetInt("UseMoney2"));
    }

    public void Plus()
    {
        PlayerPrefs.SetInt("UseMoney1", int.Parse(money1_txt.text) + 100);
        PlayerPrefs.SetInt("UseMoney2", int.Parse(money2_txt.text) + 100);
    }
    #endregion


}
