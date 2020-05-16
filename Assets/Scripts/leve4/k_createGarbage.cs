using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_createGarbage : MonoBehaviour
{
    //此脚本用来创建食物
    public GameObject createGarbage;//设置创建对象
    public GameObject cteate_Parent;//创建父级

    private void Start()
    {
        InvokeRepeating("create", 0f, 1.5f);

    }

    #region 定义一个创建的方法
    void create()
    {
        int r = Random.Range(0, 3);
        Vector2 create_pos;
        switch (r)
        {
            case 0:
                create_pos = k_var.pathUp_pos;
                break;
            case 1:
                create_pos = k_var.pathMiddle_pos;
                break;
            default:
                create_pos = k_var.pathDown_pos;
                break;
        }

        GameObject new_Obj = Instantiate(createGarbage);  //克隆个体
        new_Obj.transform.position = create_pos;//设置克隆个体位置
        new_Obj.transform.SetParent(cteate_Parent.transform); //将克隆个体放在设置好的父节点之下
    }
    #endregion

}
