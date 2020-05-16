using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_attract : MonoBehaviour
{

    public static bool isAttract = false;
    GameObject Player;

    void Start()
    {
        Player = GameObject.FindWithTag("player");//玩家对象
    }


    void Update()
    {

        //吸引食物
        if (isAttract)
        {
            Transform target = Player.transform;
            transform.position = Vector2.Lerp(transform.position, target.position, 0.1f);

        }

    }
}
