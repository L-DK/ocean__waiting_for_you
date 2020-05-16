using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_RandomstaicRubbish : MonoBehaviour
{
    public float x;
    public GameObject staticRubbish;
    void Start()
    {
        //创建静态垃圾
        InvokeRepeating("CreatestaicApple", 1f, 1f);
        staticRubbish.transform.position = new Vector2(x, 6f);
    }
    void CreatestaicApple()
    {
        if (LML_RandomObsacle.y < 50)
        {
            //让生成的垃圾控制在障碍物的范围内
            x = Random.Range(LML_RandomObsacle.x - (LML_RandomObsacle.Obsaclewidth) / 2, LML_RandomObsacle.x + (LML_RandomObsacle.Obsaclewidth) / 2);
            staticRubbish.GetComponent<Transform>().position = new Vector2(x, LML_RandomObsacle.y + 1f);
            int r = Random.Range(0,2);
            //生成一个垃圾
            if (r==0)
            {
                GameObject obj = GameObject.Instantiate(staticRubbish);

            }
            //生成两个垃圾 且不重合
            if (r == 1)
            {
                GameObject obj1 = GameObject.Instantiate(staticRubbish);
                obj1.transform.position = new Vector2(x -1f, LML_RandomObsacle.y + 1f);
                GameObject obj2 = GameObject.Instantiate(staticRubbish);
                obj2.transform.position = new Vector2(x, LML_RandomObsacle.y + 1f);

            }
        }
    }

}
