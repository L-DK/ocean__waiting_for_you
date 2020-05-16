using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_Fall : MonoBehaviour
{
    public GameObject Litter;
    public GameObject food;
    public static float speed = 0.05f;
    public static float speed1 = 0.07f;

    // Use this for initialization
    void Start()
    {
        LML_LitterFall.LitterX = Litter.transform.position.x;
        LML_LitterFall.LitterY = Litter.transform.position.y;
        LML_LitterFall.foodX = food.transform.position.x;
        LML_LitterFall.foodY = food.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        LML_LitterFall.LitterX = Litter.transform.position.x;
        LML_LitterFall.LitterY = Litter.transform.position.y;
        LML_LitterFall.foodX = food.transform.position.x;
        LML_LitterFall.foodY = food.transform.position.y;
        Litter.transform.position = new Vector2(LML_LitterFall.LitterX, LML_LitterFall.LitterY - speed);
        food.transform.position = new Vector2(LML_LitterFall.foodX, LML_LitterFall.foodY - speed1);
    }

}
