using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LML_CanvasVal : MonoBehaviour
{


    public int Index;//数组下标
    //public static int Score;//初始分数
    public int Level;//初始关卡
    public int ProLevel = 1;
    public Text scoreTex;//分数文本框
    public Text LevelTex;//关卡文本框

    //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    public Text DistanceTex;//目标距离文本框
    public Text NowDistanceTex;//当前距离文本框
    public GameObject Role;
    //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    public Text ZZTex;//珍珠数量文本框
    public Text SHTex;//珊瑚数量文本框
    public Text WinZZTex;//珍珠数量文本框
    public Text WinSHTex;//珊瑚数量文本框
    public Sprite[] foods;//创建食物数组
    public Sprite[] Rubbishs;//创建垃圾数组
    public GameObject foodsimg;//食物对象
    public GameObject Rubbishimg;//垃圾对象
    public GameObject StaicRubbishimg;//静态垃圾对象
    public GameObject LosePanel;
    public GameObject Bac;
    public Sprite BacH;
    public int ZZnumber;//随机产生珍珠数量
    public int SHnumber;//随机产生珊瑚数量


    void Start()
    {
        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加
        //Role = GameObject.Find("GameObject");
        //DistanceTex.GetComponent<Text>().text = string.Format("目标：55");
        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    
        //ZZnumber = Random.Range(3, 6);
        //SHnumber = Random.Range(0, 3);
        //scoreTex.GetComponent<Text>().text = string.Format("分数：{0}", level1_score.score);
        //LevelTex.GetComponent<Text>().text = string.Format("第{0}关", Level);
        //SHTex.GetComponent<Text>().text = string.Format("{0}", 0);
        //WinSHTex.GetComponent<Text>().text = string.Format("{0}", 0);
        //获取食物的精灵图
        SpriteRenderer spr = foodsimg.GetComponent<SpriteRenderer>();
        spr.sprite = foods[Index];
        //获取垃圾的精灵图
        SpriteRenderer spr1 = Rubbishimg.GetComponent<SpriteRenderer>();
        spr1.sprite = Rubbishs[Index];
        //获取静态垃圾的精灵图
        SpriteRenderer spr2 = StaicRubbishimg.GetComponent<SpriteRenderer>();
        spr2.sprite = Rubbishs[Index];
    }
    void Update()
    {
        //level1_score.curDistance = (int)Role.transform.position.y;
        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加
        //if ((int)Role.transform.position.y < 1)
        //{
        //    NowDistanceTex.GetComponent<Text>().text = string.Format("当前：0");
        //}
        //else
        //{
        //    NowDistanceTex.GetComponent<Text>().text = string.Format("当前：{0}", (int)Role.transform.position.y);
        //}
        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

        //ZZTex.GetComponent<Text>().text = string.Format("{0}", level1_score.score * ZZnumber);
        //WinZZTex.GetComponent<Text>().text = string.Format("{0}", level1_score.score * ZZnumber);
        //scoreTex.GetComponent<Text>().text = string.Format("分数：{0}", level1_score.score);
        //LevelTex.GetComponent<Text>().text = string.Format("第{0}关", Level);
        //if (level1_score.score > 3)
        //{
        //    SHTex.GetComponent<Text>().text = string.Format("{0}", SHnumber);
        //    WinSHTex.GetComponent<Text>().text = string.Format("{0}", SHnumber);
        //}
        //if (LML_Move.isDeath)
        //{
        //    LosePanel.SetActive(true);
        //    Bac.GetComponent<SpriteRenderer>().sprite = BacH;
        //    Time.timeScale = 0;
        //    LML_var.ObsSpeed = 0f;
        //    LML_var.bgSpeed = 0f;
        //    LML_Move.isDeath = false;
        //}
    }
}
