using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skii_jump : MonoBehaviour
{
    public Text skii_num_txt;
    int skii_time = 30;


    void Start()
    {
        InvokeRepeating("run", 0f, 1.0F);
    }

    void Update()
    {

        skii_num_txt.text = "" + skii_time;

    }

    void run()
    {
        Debug.Log("run");
        if (skii_time > 0)
        {
            Debug.Log("ru1n");
            skii_time--;

        }

    }
        
    public void skii()
    {
        if (skii_time == 0)
        {
            Debug.Log("使用了技能");
            skii_time = 10;
        }
    }
}
