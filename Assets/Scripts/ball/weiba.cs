using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weiba : MonoBehaviour
{

    public Material m1;//huang
    public Material m2;//lan
    public Material m3;//zhi
    TrailRenderer tr;
    void Start()
    {
        tr = this.GetComponent<TrailRenderer>();
    }

    void Update()
    {
        if (SKY.isyellow)
        {
            tr.material = m1;
        }
        else if (SKY.isblue)
        {
            tr.material = m2;
        }
        else if (SKY.ispurple)
        {
            tr.material = m3;

        }
    }
}
