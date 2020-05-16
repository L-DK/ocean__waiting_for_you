using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class details_role : MonoBehaviour
{

    public Sprite[] arr;
    public GameObject role_detail_plane;
    //public Text money1_txt;
    //public Text money2_txt;
    private void Start()
    {
        if (varDate.ShopOrRole == 0)
        {
            foreach (var item in arr)
            {

                if (item.name == varDate.shop_detail_name)
                {
                    role_detail_plane.GetComponent<Image>().sprite = item;
                    //Debug.Log(item.GetInstanceID());
                }
            }
        }
        if (varDate.ShopOrRole == 1)
        {
            foreach (var item in arr)
            {

                if (item.name == varDate.role_detail_name)
                {
                    role_detail_plane.GetComponent<Image>().sprite = item;
                    //Debug.Log(item.GetInstanceID());
                }
            }
        }
            

    }

    //private void Update()
    //{
    //    money1_txt.text = "" + varDate.money1;
    //    money2_txt.text = "" + varDate.money2;
    //}
    public void back()
    {
        if (varDate.ShopOrRole == 0)
        {
            SceneManager.LoadScene("Shop");

        }
        if (varDate.ShopOrRole == 1)
        {
            SceneManager.LoadScene("roledetails");

        }

    }
}
