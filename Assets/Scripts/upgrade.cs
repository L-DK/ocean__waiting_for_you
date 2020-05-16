using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrade : MonoBehaviour {

    //“珊瑚不够”提示面板
    GameObject BuGou;
    //“珍珠不够”提示面板
    GameObject ZZBuGou;
    //“满级”提示面板
    GameObject Full;
    //"不必购买"提示面板
    GameObject NoNeedPurchase;
    //"已购买"提示面板
    GameObject Purchased;
    //"未购买"提示面板
    GameObject UnGrade;
    //
    Text Need;
    Text Leve;
    Text NeedZZ;

    //角色下标
    int RoleSign;

    public void Awake()
    {
        //PlayerPrefs.SetString("UseMoney2", "600");
        
        
        
        
        if (varDate.ShopOrRole == 0)
        {
            RoleSign = varDate.shop_detail_id;
            NeedZZ = GameObject.Find("needZZ").gameObject.GetComponent<Text>();
            NeedZZ.text = varDate.NeedArr[RoleSign].ToString();
            ZZBuGou = GameObject.Find("Canvas").transform.Find("BuGou").gameObject;
            NoNeedPurchase = GameObject.Find("Canvas").transform.Find("NoNeedPurchase").gameObject;
            Purchased = GameObject.Find("Canvas").transform.Find("Purchased").gameObject;

            //不属于初级角色
            if (RoleSign > 3)
            {   //且已经购买的显示“已购买”
                if (PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase") == 1)
                {
                    Purchased.SetActive(true);
                }
            }
            
        }
        if (varDate.ShopOrRole == 1)
        {
            RoleSign = varDate.role_detail_id;
            Need = GameObject.Find("need").gameObject.GetComponent<Text>();
            Leve = GameObject.Find("leve").gameObject.GetComponent<Text>();
            BuGou = GameObject.Find("Canvas").transform.Find("BuGou").gameObject;
            Full = GameObject.Find("Canvas").transform.Find("Full").gameObject;
            UnGrade = GameObject.Find("Canvas").transform.Find("UnGrade").gameObject;

            if (RoleSign > 3)
            {
                //未购买的显示“未购买”面板
                if ((PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase") == 0))
                {
                    UnGrade.SetActive(true);
                }
            }
            
        }




    }
    public void Update()
    {
        //无限
        if (PlayerPrefs.GetInt("UseMoney1") ==0 || PlayerPrefs.GetInt("UseMoney2") ==0)
        {
            PlayerPrefs.SetInt("UseMoney1", 99999);
            PlayerPrefs.SetInt("UseMoney2", 99999);
        }
        Debug.Log("珍珠" + PlayerPrefs.GetInt("UseMoney1") + "珊瑚" + PlayerPrefs.GetInt("UseMoney2"));

      
        GameObject.Find("money1_txt").gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("UseMoney1").ToString();
        GameObject.Find("money2_txt").gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("UseMoney2").ToString();

        if (varDate.ShopOrRole == 1)
        {
            Leve.text = PlayerPrefs.GetInt(RoleSign.ToString() + "Leve").ToString();
            Need.text = PlayerPrefs.GetInt(RoleSign.ToString() + "Need").ToString();
            //初始化
            if (Leve.text == "0")
            {
                PlayerPrefs.SetInt(RoleSign.ToString() + "Leve", 1);
                PlayerPrefs.SetInt(RoleSign.ToString() + "Need", 50);
            }
        }


        //PlayerPrefs.DeleteAll();


    }

    //按钮点击执行
    public void Upgrade() {

        if (varDate.ShopOrRole == 0)
        {
            //送的角色点击时显示“不需要购买”面板
            if (RoleSign >= 0 && RoleSign <= 3)
            {
                NoNeedPurchase.SetActive(true);
                Invoke("NoNeedPurchaseHide", 1.5f);
            }
            //未购买的点击时
            if (RoleSign >= 3)
            {
                if (PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase") == 0)
                {
                    Debug.Log(PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase"));
                    //先算钱
                    Purchase();
                    //再提示
                    Purchased.SetActive(true);
                    Debug.Log(RoleSign);
                    GameObject.Find("GameObjectDisplay").transform.Find(RoleSign.ToString()).gameObject.SetActive(true);
                    GameObject.Find("ButtonReturn").gameObject.SetActive(false);
                    //RoleDisplay.displayArr[RoleSign].SetActive(true); 
                    //最后设置未已购买
                    PlayerPrefs.SetInt(RoleSign.ToString() + "IsPurchase", 1);
                    Debug.Log(PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase"));
                }
            }
            
            
            
        }

        if (varDate.ShopOrRole == 1)
        {
            if (PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase") == 0)
            {
                if (RoleSign >= 0 && RoleSign <= 3)
                {
                    if (int.Parse(Leve.text) == 20)
                    {
                        Full.SetActive(true);
                        Invoke("BuGouHide", 1.5f);
                    }
                    else
                    {
                        grade();
                    }
                }
            }
            //已购买的角色
            if (PlayerPrefs.GetInt(RoleSign.ToString() + "IsPurchase") == 1)
            {
                //普通及初级角色限制等级
                if (RoleSign >= 4 && RoleSign <= 8)
                {
                    if (int.Parse(Leve.text) == 30)
                    {
                        Full.SetActive(true);
                        Invoke("BuGouHide", 1.5f);

                    }
                    else
                    {
                        grade();
                    }

                }

                //中级角色限制等级
                if (RoleSign >= 9 && RoleSign <= 15)
                {
                    if (int.Parse(Leve.text) == 40)
                    {
                        Full.SetActive(true);
                        Invoke("BuGouHide", 1.5f);

                    }
                    else
                    {
                        grade();
                    }

                }

                //高级角色限制等级
                if (RoleSign >= 16 && RoleSign <= 20)
                {
                    if (int.Parse(Leve.text) == 50)
                    {
                        Full.SetActive(true);
                        Invoke("BuGouHide", 1.5f);

                    }
                    else
                    {
                        grade();
                    }

                }
            }
            
        }
        


    }

    //购买方法
    public void Purchase()
    {
        if (int.Parse(GameObject.Find("money1_txt").gameObject.GetComponent<Text>().text) >= int.Parse(NeedZZ.text))
        {
            GameObject.Find("money1_txt").gameObject.GetComponent<Text>().text = (int.Parse(GameObject.Find("money1_txt").gameObject.GetComponent<Text>().text) - int.Parse(NeedZZ.text)).ToString();
            PlayerPrefs.SetInt("UseMoney1", int.Parse(GameObject.Find("money1_txt").gameObject.GetComponent<Text>().text));
        }
    }

    //升级方法
    public void grade()
    {
        if (int.Parse(GameObject.Find("money2_txt").gameObject.GetComponent<Text>().text) >= int.Parse(Need.text))
        {
            //先更新数据库里的珊瑚数
            GameObject.Find("money2_txt").gameObject.GetComponent<Text>().text = (int.Parse(GameObject.Find("money2_txt").gameObject.GetComponent<Text>().text) - int.Parse(Need.text)).ToString();
            PlayerPrefs.SetInt("UseMoney2", int.Parse(GameObject.Find("money2_txt").gameObject.GetComponent<Text>().text));
            //再升级
            Leve.text = (int.Parse(Leve.text) + 1).ToString();
            PlayerPrefs.SetInt(RoleSign.ToString() + "Leve", int.Parse(Leve.text));

            //最后更新下一级所需珊瑚数
            Need.text = (int.Parse(Need.text) + 50).ToString();
            PlayerPrefs.SetInt(RoleSign.ToString() + "Need", int.Parse(Need.text));
            //Debug.Log("666");

        }
        else
        {
            BuGou.SetActive(true);
            Invoke("BuGouHide", 1.5f);
        }
    }

    public void BuGouHide()
    {
        BuGou.SetActive(false);
        Full.SetActive(false);
    }

    public void NoNeedPurchaseHide()
    {
        NoNeedPurchase.SetActive(false);
    }

    public void turnOff()
    {
        GameObject.Find(RoleSign.ToString()).gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("ButtonReturn").gameObject.SetActive(true);
    }
}
