using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_CameraFollow : MonoBehaviour
{

    // Use this for initialization
    float x;
    public static float y;
    float z;
    public GameObject background;
    public GameObject WinPanel;
    public float deviationy = 5f;
    public GameObject GameRole;


    void Start()
    {
        x = this.transform.position.x;
        z = this.transform.position.z;
        this.transform.position = new Vector3(x, 0, z);
 

    }
    void Update()
    {
        y = this.transform.position.y;
        if (LML_BackgroundMove.IsStart)
        {
            this.transform.position = new Vector3(x, LML_BackgroundMove.Roley + deviationy, z);
            background.GetComponent<Transform>().position = new Vector2(x, y);
        }


        

    }
}
