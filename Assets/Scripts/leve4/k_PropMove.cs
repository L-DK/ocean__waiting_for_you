using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_PropMove : MonoBehaviour {

    Vector2 pos;
	void Update () {
        //金币移动
        pos = this.transform.position;
        transform.position = new Vector2(pos.x - k_var.PropSpeed, pos.y);

        if (pos.x <= -(k_var.CameraWidth / 2))//垃圾移动超出屏幕销毁
        {
            Destroy(this.gameObject);
        }
    }
}
