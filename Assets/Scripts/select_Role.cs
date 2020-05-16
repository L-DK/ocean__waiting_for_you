using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class select_Role : MonoBehaviour, IPointerClickHandler
{
    GameObject root;
    GameObject loading;

    private void Start()
    {
        root = GameObject.Find("Canvas");
        loading = root.transform.Find("loading").gameObject;
        loading.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
       
        varDate.role_name = name;//静态角色变量赋值
        Debug.Log("点击角色" + varDate.role_name);

        switch (varDate.Go_Level)
        {

            case 1:
                SceneManager.LoadScene("leve1");
                break;
            case 2:
                SceneManager.LoadScene("leve2");
                break;
            case 3:
                SceneManager.LoadScene("leve3");
                break;
            case 4:
                SceneManager.LoadScene("leve4");
                break;
            default:
                break;
        }
        loading.SetActive(true);
    }
}
