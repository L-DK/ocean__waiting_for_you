using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_BackgroundMove : MonoBehaviour {

    Renderer rend;//定义Renderer组件
    Vector2 oldOffset;//定义场景偏移量

    void Start()
    {
        rend = this.GetComponent<Renderer>();//获取Renderer组件
    }

    void Update()
    {

        oldOffset = rend.material.mainTextureOffset;//获取偏移量
        float x = oldOffset.x;//获取X轴偏移量
        rend.material.mainTextureOffset = new Vector2(x + k_var.bgSpeed, 0);//偏移speed

    }
}
