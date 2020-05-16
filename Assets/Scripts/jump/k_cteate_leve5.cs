using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_cteate_leve5 : MonoBehaviour
{
    public GameObject food;
    public GameObject obj_hy;//创建对象
    public GameObject obj_null;//创建对象
    public GameObject obj_ey;//创建对象
    public GameObject obj_pz;//创建对象
    public GameObject defaultObj;//创建对象
    public GameObject tmp;//临时父级
    GameObject obj;//创建对象
    public static ArrayList arr = new ArrayList();//创建一个数组来存放克隆对象
    int cnum = 3;//随机空白
    Vector2 currentPos;
    void Start()
    {
        arr.Add(defaultObj);//添加进数组
        currentPos = defaultObj.transform.position;//保存默认位置
        InvokeRepeating("create_obj", 0f, .1f);
    }



    void create_obj()
    {
        int r = Random.Range(0, 3);
        switch (r)
        {
            case 0:
                obj = (GameObject)Instantiate(obj_hy);//创建克隆
                break;
            case 1:
                obj = (GameObject)Instantiate(obj_ey);//创建克隆
                break;
            case 2:
                obj = (GameObject)Instantiate(obj_pz);//创建克隆
                break;

        }
        cnum--;
        if (cnum <= 0)
        {
            obj = (GameObject)Instantiate(obj_null);//创建克隆

            int r2 = Random.Range(3, 6);
            switch (r2)
            {
                case 3:
                    cnum = 3;
                    break;
                case 4:
                    cnum = 4;
                    break;
                case 5:
                    cnum = 5;
                    break;

                default:
                    cnum = 3;
                    break;
            }
        }
        GameObject c_Food = (GameObject)Instantiate(food);//创建克隆
        c_Food.transform.position = new Vector2(currentPos.x + 2.5f, currentPos.y + 1f);//创建的位置
        c_Food.transform.parent = tmp.transform;
        obj.transform.position = new Vector2(currentPos.x + 2.5f, currentPos.y);//创建的位置
        obj.transform.parent = tmp.transform;
        arr.Add(obj);//添加进数组
        currentPos = obj.transform.position;


    }
}
