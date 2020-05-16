using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

    public GameObject player;
    public GameObject gameOverPlane;
    public GameObject share;
    public GameObject Load;
    public GameObject cart;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public GameObject sm;


    public void _Back()
    {

        //var.isGameOver = false;
        //SceneManager.LoadScene(0);
        //share.SetActive(false);

    }
    public void back_select()
    {
        SceneManager.LoadScene("Select_child");

    }
    public void reset()
    {
        ball_var.isGameOver = false;
        SceneManager.LoadScene("leve2");
        share.SetActive(false);
        ball_var.isGameOver = false;

    }

    

}
