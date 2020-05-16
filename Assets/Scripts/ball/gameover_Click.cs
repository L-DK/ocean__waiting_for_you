using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover_Click : MonoBehaviour
{

    public void back()
    {
        SceneManager.LoadScene("Main");
    }

    public void next()
    {
        SceneManager.LoadScene("leve2");
    }
}
