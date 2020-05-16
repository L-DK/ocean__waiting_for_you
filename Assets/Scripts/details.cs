using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class details : MonoBehaviour, IPointerClickHandler
{
    public static string rolename;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (varDate.ShopOrRole == 0)
        {
            Debug.Log(varDate.ShopOrRole);
            varDate.shop_detail_name = name;

            //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

            varDate.shop_detail_id = int.Parse(this.gameObject.tag);
            Debug.Log(int.Parse(this.gameObject.tag));
            Debug.Log(varDate.shop_detail_name);
            Debug.Log(varDate.shop_detail_id);
            //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

            SceneManager.LoadScene("shop_detail");
        }
        if (varDate.ShopOrRole == 1)
        {
            varDate.role_detail_name = name;

            //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

            varDate.role_detail_id = int.Parse(this.gameObject.tag);
            Debug.Log(int.Parse(this.gameObject.tag));
            Debug.Log(varDate.role_detail_name);
            Debug.Log(varDate.role_detail_id);
            //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

            SceneManager.LoadScene("role_detail_1");
        }


    }

}
