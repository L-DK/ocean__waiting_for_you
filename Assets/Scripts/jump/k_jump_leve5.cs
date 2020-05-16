using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class k_jump_leve5 : MonoBehaviour
{

    Renderer rend;//定义Renderer组件
    Vector2 oldOffset;//定义场景偏移量
    public GameObject gb;
    bool isGround = true;
    Rigidbody2D rb;
    bool ismove = false;
    GameObject target;
    Vector2 target_pos;
    public static int target_key = 0;
    GameObject Obj_col_Ey;
    public GameObject over;
    public GameObject win;
    public GameObject lose;


    void Start()
    {
        k_cteate_leve5.arr.Clear();
        target_key = -1;




        win.SetActive(false);
        lose.SetActive(false);
        k_score_leve5.isgameover = false;
        k_score_leve5.iswin = false;
        rend = gb.GetComponent<Renderer>();//获取Renderer组件
        rb = GetComponent<Rigidbody2D>();
    }

    public void jump1()
    {

        try
        {
            if (isGround)
            {
                target_key++;
                target = (GameObject)k_cteate_leve5.arr[target_key];
                target_pos = target.transform.position;
                rb.velocity = new Vector2(10f, 3f);
            }
        }
        catch (Exception e1)
        {

            throw;
        }
    }
    public void jump2()
    {
        try
        {

            if (isGround)
            {

                target_key += 2;
                target = (GameObject)k_cteate_leve5.arr[target_key];
                target_pos = target.transform.position;
                rb.velocity = new Vector2(16f, 3f);


            }
        }
        catch (Exception e2)
        {

            throw;
        }
    }
    void Update()
    {
        if (k_score_leve5.isgameover == true)
        {

            if (k_score_leve5.iswin)
            {
                win.SetActive(true);

            }
            else
            {
                lose.SetActive(true);
            }
        }




        if (Input.GetKeyDown(KeyCode.A) && isGround)
        {

            target_key++;
            target = (GameObject)k_cteate_leve5.arr[target_key];
            target_pos = target.transform.position;
            rb.velocity = new Vector2(10f, 3f);
        }
        if (Input.GetKeyDown(KeyCode.D) && isGround)
        {

            target_key += 2;
            target = (GameObject)k_cteate_leve5.arr[target_key];
            target_pos = target.transform.position;
            rb.velocity = new Vector2(16f, 3f);


        }

        if (transform.position.y > 0.22f)
        {
            isGround = false;
        }

        if (transform.position.y <= -8)
        {
            //Debug.Log("游戏结束");

            k_score_leve5.isgameover = true;
        }

        if (ismove)
        {
            Vector3 cp = Camera.main.transform.position;
            if (cp.x != transform.position.x)
            {
                Camera.main.transform.position = new Vector3(cp.x + 0.5f, cp.y, cp.z);

                oldOffset = rend.material.mainTextureOffset;//获取偏移量
                float x = oldOffset.x;//获取X轴偏移量
                rend.material.mainTextureOffset = new Vector2(x + 0.008f, 0);//偏移speed
            }
            if (cp.x >= transform.position.x)
            {
                ismove = false;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D col)

    {

        begin = DateTime.Now;
        rb.velocity = new Vector2(0, 0);
        ismove = true;
        transform.position = new Vector2(target_pos.x, transform.position.y);

        if (col.gameObject.tag == "Ey")
        {

            Obj_col_Ey = col.gameObject;

        }


    }


    DateTime begin;
    private void OnCollisionStay2D(Collision2D col)
    {
        #region 站几秒后发生事件

        float t = float.Parse((DateTime.Now - begin).ToString().Split(':')[2]);
        int i = (int)(t * 100);
        t = (float)(i * 1.0) / 100;
        isGround = true;
        if (col.gameObject.tag == "Ey")
        {
            if (t >= .3f)
            {
                if (Obj_col_Ey.transform.rotation.z == 0)
                {
                    Obj_col_Ey.transform.Rotate(new Vector3(0, 0, -90));
                    k_score_leve5.isgameover = true;
                    lose.SetActive(true);
                    Debug.Log("游戏结束");
                    gameObject.SetActive(false);
                }
            }

        }

        if (col.gameObject.tag == "Pz")
        {
            if (t > .2f)
            {
                col.gameObject.AddComponent<Rigidbody2D>();
                col.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3f;
            }
        }
        #endregion
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "food")
        {
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
            k_score_leve5.score++;

        }

    }



}
