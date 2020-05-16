using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LML_Move : MonoBehaviour
{
    public static float x;
    public static float Startx;
    public static float y;
    public static float Starty;
    public GameObject GameRole;
    public static bool isDeath = false;
    public GameObject tipscoltxt;
    public GameObject tipscoltxt2;
    public GameObject pro;
    bool ispro = false;
    #region 加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    public GameObject Tips;

    //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

    #endregion

    // Animator ani;
    public void Awake()
    {

        Screen.SetResolution(1080, 1920, true);
        Screen.orientation = ScreenOrientation.PortraitUpsideDown;

    }




    void Start()
    {
        ispro = false;
 
        tipscoltxt2.SetActive(false);
        tipscoltxt.SetActive(false);
        Startx = this.transform.position.x;
        Starty = this.transform.position.y;
    }

    public void use_skii() {
        if (!ispro)
        {
            ispro = true;
            skii.skii_time = 30;
            skii.isrun = true;
        }
  
    }

    public void stop_skii()
    {
        ispro = false;
    }
    void Update()
    {
        if (ispro)
        {
            pro.SetActive(true);
        }
        else
        {
            pro.SetActive(false);
        }

        
        //让角色不旋转
        GameRole.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f); ;
        //控制角色
        x = this.transform.position.x;
        y = this.transform.position.y;
        if (Input.GetKey(KeyCode.D))
        {
            LML_LitterFall.isCreat1 = true;
            this.transform.position = new Vector2(x + 0.05f, y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            LML_LitterFall.isCreat1 = true;
            this.transform.position = new Vector2(x - 0.05f, y);
        }


        //if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        //{

        //}
        #region 加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Tips.SetActive(false);
            LML_BackgroundMove.IsStart = true;
            LML_LitterFall.isCreat1 = true;
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * 0.01f, 0, 0);
        }

        //加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加加

        #endregion

        if (this.transform.position.x <= LML_LitterFall.referXL || this.transform.position.x >= LML_LitterFall.referXR)
        {
            this.transform.position = new Vector2(x, y);
        }
 
    }
    public void CreatPos()
    {
        this.gameObject.SetActive(true);
        LML_BackgroundMove.IsStart = true;
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("产生碰撞了");
        if (col.gameObject.name.Contains("石头"))
        {
            Debug.Log("撞到石头了");
            tipscoltxt.SetActive(true);
        }

        begin = DateTime.Now;
        //判断角色是否与垃圾碰撞

        if (col.gameObject.name.Contains("rubbish"))
        {
            if (ispro)
            {
                Debug.Log("ispro");
                Destroy(col.gameObject);
                pro.SetActive(false);
                ispro = false;
            }
            else
            {
                Destroy(col.gameObject);
                level1_score.isgameover = true;
                LML_BackgroundMove.IsStart = false;
                ispro = false;
                this.gameObject.SetActive(false);
            }


        } //判断角色是否与食物碰撞
        else if (col.gameObject.name.Contains("fish"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            //col.gameObject.GetComponent<AudioSource>().Play();
            //col.gameObject.SetActive(false);
            Destroy(col.gameObject);
            level1_score.score++;
        }



    }
    DateTime begin;
    private void OnCollisionStay2D(Collision2D col)
    {

        float t = float.Parse((DateTime.Now - begin).ToString().Split(':')[2]);
        int i = (int)(t * 100);
        t = (float)(i * 1.0) / 100;
        if (t >= 2)
        {
            Destroy(col.gameObject);
            this.gameObject.SetActive(false);
            isDeath = true;
            level1_score.isgameover = true;
            LML_BackgroundMove.IsStart = false;
            tipscoltxt2.SetActive(true);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        tipscoltxt.SetActive(false);


    }


}
