using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_protect_col : MonoBehaviour
{
    //护盾碰撞检测
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("碰到护盾");
            this.gameObject.SetActive(false);
            Destroy(col.gameObject);
        }

    }
}
