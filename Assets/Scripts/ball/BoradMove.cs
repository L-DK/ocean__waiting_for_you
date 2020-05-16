using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoradMove : MonoBehaviour
{
    Vector3 pos;
    public Vector2 moveRange = new Vector2(-0.75f, 0.75f);
    public float moveSpeed = 1f;
    public Material ma1;
    private void Start()
    {
        if (gameObject.tag == "NULL")
        {
            gameObject.GetComponent<Renderer>().material = ma1;

        }
        if (this.gameObject.name == "move")
        {
            pos = this.transform.position;
        }

    }
    void Update()
    {
        if (this.gameObject.name == "move")
        {
            this.transform.position = new Vector3(
             Mathf.PingPong(Time.time * moveSpeed, moveRange.y - moveRange.x) - moveRange.y, pos.y, pos.z);

        }
    }


}
