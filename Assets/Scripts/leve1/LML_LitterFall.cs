using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_LitterFall : MonoBehaviour
{
    #region 静态变量
    public static float LitterX;
    public static float LitterY;
    public static float foodX;
    public static float foodY;
    public static float referPositiony;
    public static float cameray;
    public static float referXL;
    public static float referXR;
    public static bool isCreat1 = false;
    public static float Sappear_time = 2.0f;
    public static float Dappear_time = 5.0f;
    #endregion
    // Use this for initialization
    public GameObject ActiveLitter;
    public GameObject food;
    public GameObject referPos;
    float LitterHeight;
    public GameObject referxl;
    public GameObject referxr;


    //创建垃圾对象
    void GreatLitter()
    {
        ActiveLitter.transform.position = new Vector2(Random.Range(referXL, referXR), referPositiony);
        GameObject.Instantiate(ActiveLitter);
    }
    //创建食物对象
    void CreateFood()
    {
        food.transform.position = new Vector2(Random.Range(referXL, referXR), referPositiony);
        GameObject.Instantiate(food);
    }
    void Start()
    {
        LitterX = ActiveLitter.transform.position.x;
        LitterY = ActiveLitter.transform.position.y;
        foodX = food.transform.position.x;
        foodY = food.transform.position.y;
        InvokeRepeating("Generate", 1f, 2f);
        referPositiony = referPos.GetComponent<Transform>().position.y;
        cameray = referPos.GetComponent<Transform>().position.y;
        referXL = referxl.GetComponent<Transform>().position.x;
        referXR = referxr.GetComponent<Transform>().position.x;

    }
    void Generate()
    {
        if (isCreat1)
        {
            Invoke("GreatLitter", Random.Range(Sappear_time, Dappear_time));
            Invoke("CreateFood", Random.Range(Sappear_time, Dappear_time+1f));
        }
    }

    void Update()
    {
        referPositiony = referPos.GetComponent<Transform>().position.y;
        foodX = food.transform.position.x;
        LitterX = ActiveLitter.transform.position.x;
    }
}
