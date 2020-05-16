using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_ctrl : MonoBehaviour
{

    Animator ani;
    public GameObject Protect;
    public GameObject Attract;
    public GameObject Invincible;
    public GameObject win;
    public GameObject lose;

    private void Awake()
    {
        win.SetActive(false);
        lose.SetActive(false);
    }
    void Start()

    {
        Attract.SetActive(false);
        k_attract.isAttract = false;

        ani = this.GetComponent<Animator>();

    }

    void Update()
    {
        if (k_var.isgameover)
        {
            if (k_var.iswin)
            {
                win.SetActive(true);
            }
            else
            {
                lose.SetActive(true);
            }

        }



        if (Input.GetKeyDown(KeyCode.J))//护盾调试
        {
            if (Protect.activeSelf)
            {
                Protect.SetActive(false);
            }
            else
            {
                Protect.SetActive(true);
            }

        }
        if (Input.GetKeyDown(KeyCode.K))//吸引调试
        {
            if (Attract.activeSelf)
            {
                Attract.SetActive(false);
                k_attract.isAttract = false;
            }
            else
            {

                Attract.SetActive(true);
                k_attract.isAttract = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.L))//无敌调试
        {

            if (Invincible.activeSelf)
            {
                Invincible.SetActive(false);
                this.gameObject.layer = LayerMask.NameToLayer("Default");//通过调整layer来实现不碰撞
                Protect.layer = LayerMask.NameToLayer("Default");//通过调整layer来实现不碰撞
            }
            else
            {
                Invincible.SetActive(true);
                this.gameObject.layer = LayerMask.NameToLayer("Invincible");//通过调整layer来实现不碰撞
                Protect.layer = LayerMask.NameToLayer("Invincible");//通过调整layer来实现不碰撞
            }
        }


        ////====================================
        //Vector2 pos = transform.position;
        //if (Input.GetKey(KeyCode.W) && pos.y == k_var.pathMiddle_pos.y)
        //{
        //    ani.SetBool("isup", true);
        //    ani.SetBool("isdown_back", false);
        //    ani.SetBool("isup_back", false);

        //}
        //else if (Input.GetKey(KeyCode.S) && pos.y == k_var.pathUp_pos.y)
        //{
        //    ani.SetBool("isup", false);
        //    ani.SetBool("isup_back", true);

        //}
        //else if (Input.GetKey(KeyCode.S) && pos.y == k_var.pathMiddle_pos.y)
        //{
        //    ani.SetBool("isdown", true);
        //    ani.SetBool("isdown_back", false);
        //    ani.SetBool("isup_back", false);

        //}
        //else if (Input.GetKey(KeyCode.W) && pos.y == k_var.pathDown_pos.y)
        //{
        //    ani.SetBool("isdown", false);
        //    ani.SetBool("isdown_back", true);

        //}
    }

    public void Attr()
    {
        if (skii.skii_time == 0)
        {
            if (Attract.activeSelf)
            {
                Attract.SetActive(false);
                k_attract.isAttract = false;
            }
            else
            {

                Attract.SetActive(true);
                k_attract.isAttract = true;
                skii.skii_time = 15;
                skii.isrun = true;
                Invoke("stopAttr", 5f);
            }
        }
    }
    public void stopAttr()
    {
        Attract.SetActive(false);
        k_attract.isAttract = false;
    }
    public void ctrl_up()
    {
        Vector2 pos = transform.position;
        if (pos.y == k_var.pathMiddle_pos.y)
        {
            ani.SetBool("isup", true);
            ani.SetBool("isdown_back", false);
            ani.SetBool("isup_back", false);

        }
        else if (pos.y == k_var.pathDown_pos.y)
        {
            ani.SetBool("isdown", false);
            ani.SetBool("isdown_back", true);

        }

    }
    public void ctrl_down()
    {

        Vector2 pos = transform.position;
        if (pos.y == k_var.pathUp_pos.y)
        {
            ani.SetBool("isup", false);
            ani.SetBool("isup_back", true);

        }
        else if (pos.y == k_var.pathMiddle_pos.y)
        {
            ani.SetBool("isdown", true);
            ani.SetBool("isdown_back", false);
            ani.SetBool("isup_back", false);

        }

    }


}

