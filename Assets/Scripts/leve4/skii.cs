using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skii : MonoBehaviour
{
    public Text skii_num_txt;
    public static int skii_time = 0;
    public GameObject Skiiplane;
    public static bool isrun = false;

    void Start()
    {
        skii_time = 0;
        isrun = false;
        Skiiplane.SetActive(false);
        InvokeRepeating("run", 0f, 1.0F);
    }

    void Update()
    {

        skii_num_txt.text = "" + skii_time;
        if (skii_time == 0)
        {
            Skiiplane.SetActive(false);
            isrun = false;
        }
        if (isrun)
        {
            Skiiplane.SetActive(true);

        }

    }

    void run()
    {
        if (isrun)
        {
            if (skii_time > 0)
            {
                skii_time--;

            }
        }

    }

    public void skii_click()
    {
        if (skii_time == 0)
        {
            Debug.Log("使用了技能");
            skii_time = 10;
        }
    }
}
