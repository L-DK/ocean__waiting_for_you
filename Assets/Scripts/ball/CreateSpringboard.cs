using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpringboard : MonoBehaviour
{
    public GameObject clones;//克隆父对象
    public GameObject Springboard;//克隆对象
    public GameObject Springboard2;//克隆对象
    public static int boardNum = 1;//限制跳板数量
    Vector3 currentPos;
    public static ArrayList objArray = new ArrayList();//创建一个数组来存放克隆对象

    void Start()
    {
       
        currentPos = Springboard.transform.position;

    }

    void Update()
    {
     
        if (boardNum <=2)
        {

            if (Score.score < 30)
            {
                Player.CreateDstance = 3f;
                Player.Force = 4f;
            }

            if (Score.score>=30&& Score.score <=100)
            {
                int r = Random.Range(0, 5);

                if (r == 0)
                {
                    Player.CreateDstance = 3f;
                    Player.Force = 4f;
                }
                if (r == 1)
                {
                    Player.CreateDstance = 2.5f;
                    Player.Force = 3f;
                }
                if (r == 2)
                {
                    Player.CreateDstance = 1.5f;
                    Player.Force = 2.5f;
                }
                if (r == 3)
                {
                    Player.CreateDstance = 1f;
                    Player.Force = 2.3f;
                }

            }



            CreateType();

        }

    }
    public static int r_Create;
    public void CreateType()
    {
        r_Create = Random.Range(0, 4);
        int r = r_Create;
        if (r == 0)
        {

            CreateBoard();
        }
        else if (r == 1)
        {

            CreateBoard_type1();
        }
        else if (r == 2)
        {

            CreateBoard_type2();
        }
        else if (r == 3)
        {

            CreateBoard_type3();
        }
        //2.5 1

    }
    #region 创建跳板
    public void CreateBoard()
    {
        float distance = Player.CreateDstance;//距离

        float random_direction = Random.Range(-0.75f, 0.75f);//随机生成跳板左右距离
        GameObject newBoard = (GameObject)Instantiate(Springboard);//创建克隆
        newBoard.transform.position =
        new Vector3(random_direction, currentPos.y, currentPos.z + distance);//创建的位置
        newBoard.tag = "board";
        objArray.Add(newBoard);//添加进数组
        newBoard.transform.parent = clones.transform;
        currentPos = newBoard.transform.position;
        boardNum++;

    }

    public void CreateBoard_type1()//左右左右生成
    {
        float distance = Player.CreateDstance;
        float random_direction;//随机生成跳板左右距离
        if (Score.change)
        {
            random_direction = -0.75f;
            Score.change = false;
        }
        else
        {
            random_direction = 0.75f;
            Score.change = true;
        }
        GameObject newBoard = (GameObject)Instantiate(Springboard);//创建
        newBoard.transform.position = new Vector3(random_direction, currentPos.y, currentPos.z + distance);//创建的位置
        newBoard.tag = "board";
        objArray.Add(newBoard);//添加进数组
        newBoard.transform.parent = clones.transform;
        currentPos = newBoard.transform.position;
        boardNum++;
    }

    public void CreateBoard_type2()//类型2 一列
    {
        int r = Random.Range(0, 3);
        if (r == 0)
        {
            float random_distance = Player.CreateDstance;
            GameObject newboard = (GameObject)Instantiate(Springboard);//创建
            newboard.transform.position = new Vector3(0f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard.tag = "NULL";
            newboard.name = "NULL";
            GameObject newboard2 = (GameObject)Instantiate(Springboard);//创建
            newboard2.transform.position = new Vector3(-0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard2.tag = "NULL";
            newboard2.name = "NULL";
            GameObject newboard3 = (GameObject)Instantiate(Springboard);//创建
            newboard3.transform.position = new Vector3(0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard3.tag = "board";
            objArray.Add(newboard3);//添加进数组
            newboard.transform.parent = clones.transform;
            newboard2.transform.parent = clones.transform;
            newboard3.transform.parent = clones.transform;
            currentPos = newboard3.transform.position;
            boardNum++;
        }
        else if (r == 1)
        {
            float random_distance = Player.CreateDstance;
            GameObject newboard = (GameObject)Instantiate(Springboard);//创建
            newboard.transform.position = new Vector3(0f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard.tag = "board";
            GameObject newboard2 = (GameObject)Instantiate(Springboard);//创建
            newboard2.transform.position = new Vector3(-0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard2.tag = "NULL";
            newboard2.name = "NULL";
            GameObject newboard3 = (GameObject)Instantiate(Springboard);//创建
            newboard3.transform.position = new Vector3(0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard3.tag = "NULL";
            newboard3.name = "NULL";
            objArray.Add(newboard);//添加进数组
            newboard.transform.parent = clones.transform;
            newboard2.transform.parent = clones.transform;
            newboard3.transform.parent = clones.transform;
            currentPos = newboard.transform.position;
            boardNum++;
        }
        else if (r == 2)
        {
            float random_distance = Player.CreateDstance;
            GameObject newboard = (GameObject)Instantiate(Springboard);//创建
            newboard.transform.position = new Vector3(0f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard.tag = "NULL";
            newboard.name = "NULL";
            GameObject newboard2 = (GameObject)Instantiate(Springboard);//创建
            newboard2.transform.position = new Vector3(-0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard2.tag = "board";
            GameObject newboard3 = (GameObject)Instantiate(Springboard);//创建
            newboard3.transform.position = new Vector3(0.75f, currentPos.y, currentPos.z + random_distance);//创建的位置
            newboard3.tag = "NULL";
            newboard3.name = "NULL";
            objArray.Add(newboard2);//添加进数组
            newboard.transform.parent = clones.transform;
            newboard2.transform.parent = clones.transform;
            newboard3.transform.parent = clones.transform;
            currentPos = newboard2.transform.position;
            boardNum++;
        }

    }
    public void CreateBoard_type3()//yidong
    {
        float distance = Player.CreateDstance;//距离

        float random_direction = Random.Range(-0.75f, 0.75f);//随机生成跳板左右距离
        GameObject newBoard = (GameObject)Instantiate(Springboard);//创建克隆
        newBoard.transform.position =
        new Vector3(random_direction, currentPos.y, currentPos.z + distance);//创建的位置
        newBoard.tag = "board";
        newBoard.name = "move";
        objArray.Add(newBoard);//添加进数组
        newBoard.transform.parent = clones.transform;
        currentPos = newBoard.transform.position;
        boardNum++;
    }

    #endregion



}
