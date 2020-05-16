using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float Factoer = 3.5f;//跳跃高度
    public float Dstance = 3.5f;//距离
    public static float CreateDstance;//创建跳板距离
    public static float Force;//跳跃的力
    public static int num = 0;//遍历创建预设体的下标
    bool isrotate = false;//旋转
    public float speed = 0.1f;//左右移动速度
    bool isjump = false;//是否开始跳跃
    public static Vector3 targetLocation;//设置跳跃目标位置

    public static int n = 0;
    public GameObject gameOverPlane;//游戏结束面板
    public GameObject win;
    public GameObject lose;
    public GameObject blue;
    public GameObject yellow;
    public GameObject purple;
    public GameObject blue2;
    public GameObject yellow2;
    public GameObject purple2;
    public GameObject shuomingPlane;
    public GameObject tishi;
    public GameObject wjms;
    public static Material ballMaterial;
    public GameObject GREENBALL;
    public static bool gball = false;


    private void Awake()
    {
        ball_var.music_b1 = true;
        ball_var.music_b2 = false;
        ball_var.music_b3 = false;
        Score.score = 0;
        CreateSpringboard.objArray.Clear();//开始时清空存放克隆对象的数组内容
        CreateSpringboard.boardNum = 1;
        Player.num = 0;
        ball_var.isGameOver = false;
        Time.timeScale = 1;
    }


    void Start()
    {

        ball_var.iswin = false;
        ball_var.isgameover = false;
        win.SetActive(false);
        lose.SetActive(false);

        if (gball == true)
        {
            GREENBALL.SetActive(true);
        }

        rb = this.GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;  //修改物理组件的重心到body的底部
        CreateDstance = Dstance;
        Force = Factoer;
        if (ballMaterial == null)
        {

        }
        else
        {
            this.GetComponent<MeshRenderer>().material = ballMaterial;
        }


    }
    public Vector2 v = new Vector2(-1f, 1f);

    void Update()
    {
        if (Score.score == 100)
        {
            ball_var.isGameOver = true;
            ball_var.iswin = true;
        }

        if (ball_var.isgameover)
        {
            if (ball_var.iswin)
            {
                win.SetActive(true);
            }
            else
            {
                lose.SetActive(true);
            }
        }

        if (Score.score == 30)
        {
            tishi.SetActive(true);

        }
        if (Score.score == 35)
        {
            tishi.SetActive(false);

        }
        if (Score.score == 100)
        {
            wjms.SetActive(true);

        }
        if (Score.score == 105)
        {
            wjms.SetActive(false);

        }

        if (Time.time > 0f && Time.time <= 10f)
        {
            CreateSpringboard.r_Create = 1;
        }
        else if (Time.time > 10f && Time.time <= 15f)
        {

            CreateSpringboard.r_Create = 2;

        }
        if (Time.time % 10 == 0)
        {
            CreateSpringboard.r_Create = 3;
        }
        else if (!(Time.time % 10 == 0))
        {
            CreateSpringboard.r_Create = Random.Range(0, 4);
        }


        if (isrotate)
        {
            this.transform.Rotate(new Vector3(1, 0, 0) * 10f);//旋转小球

        }
        if (this.transform.position.x > v.x && this.transform.position.x < v.y)
        {
            if (Input.touchCount == 1)
            {

                if (Input.touches[0].phase == TouchPhase.Began)
                {
                    // 记录手指触屏的位置  
                    rb.useGravity = true;
                    shuomingPlane.SetActive(false);

                }
                // 手指移动  
                else if (Input.touches[0].phase == TouchPhase.Moved)
                {

                    float x = this.transform.position.x;
                    float y = this.transform.position.y;
                    float z = this.transform.position.z;
                    this.transform.Translate(new Vector3(Input.touches[0].deltaPosition.x * Time.deltaTime * 0.2f, -Input.touches[0].deltaPosition.y * Time.deltaTime * 0f, 0));
                    if (this.transform.position.x <= v.x)
                    {
                        this.transform.position = new Vector3(-0.9f, y, z);
                    }
                    if (this.transform.position.x >= v.y)
                    {
                        this.transform.position = new Vector3(0.9f, y, z);
                    }
                }
            }

        }


        if (this.transform.position.x > v.x && this.transform.position.x < v.y)
        {
            if (Input.GetKey(KeyCode.A))
            {
                float x = this.transform.position.x;
                float y = this.transform.position.y;
                float z = this.transform.position.z;
                this.transform.position = new Vector3(x - speed, y, z);
                if (this.transform.position.x <= v.x)
                {
                    this.transform.position = new Vector3(-0.9f, y, z);
                }


            }
            if (Input.GetKey(KeyCode.D))
            {


                float x = this.transform.position.x;
                float y = this.transform.position.y;
                float z = this.transform.position.z;
                this.transform.position = new Vector3(x + speed, y, z);


                if (this.transform.position.x >= v.y)
                {
                    this.transform.position = new Vector3(0.9f, y, z);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.useGravity = true;//开始游戏
            //shuomingPlane.SetActive(false);

        }

        if (isjump)
        {   //保证每次Z轴都跳到跳板上
            float x = targetLocation.x;
            float z = targetLocation.z;
            if (this.transform.position.z < z)
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + .1f);
            }
            if (this.transform.position.z == z)
            {
                isjump = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.position = new Vector3(targetLocation.x, 1f, targetLocation.z);

        }

        if (transform.position.y <= 0)
        {
            ball_var.isgameover = true;
            Time.timeScale = 0;
            rb.useGravity = false;//开始游戏
            rb.isKinematic = true;

        }

    }

    public void left_btn()
    {
    

        Debug.Log("111");
        if (this.transform.position.x > v.x && this.transform.position.x < v.y)
        {

            float x = this.transform.position.x;
            float y = this.transform.position.y;
            float z = this.transform.position.z;
            this.transform.position = new Vector3(x - speed, y, z);
            if (this.transform.position.x <= v.x)
            {
                this.transform.position = new Vector3(-0.9f, y, z);
            }



        }
    }
    public void kaishi()
    {
        if (!rb.useGravity)
        {
            rb.useGravity = true;//开始游戏
            shuomingPlane.SetActive(false);
        }
    }
    public void right_btn()
    {

        if (this.transform.position.x > v.x && this.transform.position.x < v.y)
        {


            float x = this.transform.position.x;
            float y = this.transform.position.y;
            float z = this.transform.position.z;
            this.transform.position = new Vector3(x + speed, y, z);


            if (this.transform.position.x >= v.y)
            {
                this.transform.position = new Vector3(0.9f, y, z);

            }
        }
    }

    void csh()
    {
        blue.SetActive(false);
        purple.SetActive(false);
        yellow.SetActive(false);
        blue2.SetActive(false);
        purple2.SetActive(false);
        yellow2.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "board")
        {
            col.gameObject.GetComponent<AudioSource>().Play();

            if (Score.score % 30 == 0 && Score.score != 0)
            {
                SKY.rSyk();
            }

            if (SKY.isblue)
            {
                blue.SetActive(true);
                blue2.SetActive(true);
            }
            else if (SKY.isyellow)
            {
                yellow.SetActive(true);
                yellow2.SetActive(true);

            }
            else if (SKY.ispurple)
            {
                purple.SetActive(true);
                purple2.SetActive(true);
            }


            Invoke("csh", 0.2f);

            GameObject targetObj = (GameObject)CreateSpringboard.objArray[Player.num];

            Player.targetLocation = targetObj.transform.position;//获取下一个跳板对象位置
            Player.num++;
            OnJump();

            if (num >= 2)
            {
                CreateSpringboard.boardNum--;//限制跳板数量
                Destroy(col.gameObject, 1f);//着陆一秒后销毁
            }
            Score.score += 1;

        }
        if (col.gameObject.tag == "NULL")
        {

            isrotate = false;
            Destroy(col.gameObject, 0f);
        }


    }

    void OnJump()
    {


        rb.velocity = (new Vector3(0, 1, 0)) * Force;
        isjump = true;
    }

}
