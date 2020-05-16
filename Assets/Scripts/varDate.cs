using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class varDate : MonoBehaviour
{
    //public Text money1Txt;
    //public Text money2Txt;
    public static int ShopOrRole;
    public static string role_detail_name;
    public static int role_detail_id;
    public static int Go_Level = 1;
    public static int Go_Level_child = 1;

    public static int money1 = 9998;
    public static int money2 = 9999;

    public static string role_name = "role_ht";

    public static string shop_detail_name = "role_ht";
    public static int shop_detail_id;

    //private void Start()
    //{
    //    Debug.Log(this.gameObject);
    //    money1Txt.text = "" + money1;
    //    money2Txt.text = "" + money2;
    //}


    #region 加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    //#region 角色等级

    //public static int Leve_zy = 1;
    //public static int Leve_hg = 1;
    //public static int Leve_hn = 1;
    //public static int Leve_hx = 1;
    //public static int Leve_dy = 1;
    //public static int Leve_sm = 1;
    //public static int Leve_px = 1;
    //public static int Leve_jqy = 1;

    //public static int Leve_dy1 = 1;
    //public static int Leve_hty = 1;
    //public static int Leve_hm = 1;
    //public static int Leve_dly = 1;
    //public static int Leve_zgy = 1;
    //public static int Leve_lj = 1;
    //public static int Leve_bf = 1;
    //public static int Leve_fy = 1;

    //public static int Leve_shb = 1;
    //public static int Leve_xty = 1;
    //public static int Leve_cts = 1;
    //public static int Leve_sdy = 1;
    //public static int Leve_ht = 1;

    //#endregion

    //public static int[] LeveArr = { Leve_zy, Leve_hg, Leve_hn, Leve_hx, Leve_dy , Leve_sm , Leve_px , Leve_jqy,
    //                                Leve_dy1, Leve_hty, Leve_hm, Leve_dly, Leve_zgy, Leve_lj, Leve_bf, Leve_fy,
    //                                Leve_shb, Leve_xty, Leve_cts, Leve_sdy, Leve_ht};


    #region 角色购买所需珍珠数
    public static int Need_zy = 0;
    public static int Need_hg = 0;
    public static int Need_hn = 0;
    public static int Need_hx = 0;
    public static int Need_dy = 200;
    public static int Need_sm = 200;
    public static int Need_px = 200;
    public static int Need_jqy = 200;

    public static int Need_dy1 = 200;
    public static int Need_hty = 400;
    public static int Need_hm = 400;
    public static int Need_dly = 400;
    public static int Need_zgy = 400;
    public static int Need_lj = 400;
    public static int Need_bf = 400;
    public static int Need_fy = 400;

    public static int Need_shb = 400;
    public static int Need_xty = 700;
    public static int Need_cts = 700;
    public static int Need_sdy = 700;
    public static int Need_ht = 700;

    #endregion

    public static int[] NeedArr = {  Need_zy, Need_hg, Need_hn, Need_hx, Need_dy, Need_sm , Need_px , Need_jqy ,
                                    Need_dy1, Need_hty, Need_hm, Need_dly, Need_zgy, Need_lj, Need_bf, Need_fy,
                                    Need_shb, Need_xty, Need_cts, Need_sdy, Need_ht };


    #endregion


}
