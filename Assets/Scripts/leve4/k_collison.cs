using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_collison : MonoBehaviour
{
    //敌人和金币的碰撞检测
  
    private void OnCollisionEnter2D(Collision2D col)
    {
        //触碰到垃圾
        if (gameObject.tag == "Enemy" && col.gameObject.tag == "player")
        {
            Debug.Log("碰到敌人了");
            Destroy(gameObject);
            k_var.isgameover = true;



        }

        //触碰到金币
        if ((gameObject.tag == "Food" && col.gameObject.tag == "player") || (gameObject.tag == "Food" && col.gameObject.tag == "Attract") || (gameObject.tag == "Food" && col.gameObject.tag == "protect"))
        {
            col.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("吃到食物了");
            k_var.score++;//珍珠数量+1
            Destroy(gameObject);
        }




    }
}
