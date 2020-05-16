using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_RandomObsacle : MonoBehaviour
{
    float newval;
    public static float y;
    public static float x;
    public GameObject StaicLitter;
    public GameObject obstacle;
    float obstaclex;
    public static float Obsaclewidth;
    public Camera ca;
    public GameObject pos;
    void Start()
    {
        InvokeRepeating("Generate", 1f, 1f);
        obstacle.transform.position = new Vector2(0, 6f);
        //获取石头的宽度
        Obsaclewidth = obstacle.transform.localScale.x * obstacle.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
    }

    void Generate()
    {

        y = obstacle.GetComponent<Transform>().transform.position.y;
        if (y < 50)
        {
            Invoke("CreatObsacle", 0f);

        }
    }
    void CreatObsacle()
    {
        obstacle.GetComponent<Transform>().transform.position = new Vector2(Random.Range(LML_LitterFall.referXL, LML_LitterFall.referXR), y + 5f);
        GameObject.Instantiate(obstacle);


    }
    void Update()
    {
        x = obstacle.GetComponent<Transform>().transform.position.x;
        y = obstacle.GetComponent<Transform>().transform.position.y;
        if (LML_Move.y >= LML_LitterFall.cameray * 11)
        {
            Destroy(ca.GetComponent<LML_LitterFall>());
        }
    }
}
