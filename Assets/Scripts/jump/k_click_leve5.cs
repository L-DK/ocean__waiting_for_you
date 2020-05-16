using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class k_click_leve5 : MonoBehaviour
{
    public GameObject over;

    public void res()
    {
    
    }
    public void To_Main()
    {

        SceneManager.LoadScene("Main");
     

    }
    public void next_leve3()
    {
        //k_jump_leve5.target_key = 0;
        //k_cteate_leve5.arr.Clear();
        SceneManager.LoadScene("leve3");

    }
    public void back_select()
    {
       
        SceneManager.LoadScene("Select_child");

    }
}
