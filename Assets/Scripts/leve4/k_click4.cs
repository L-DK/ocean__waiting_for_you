using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class k_click4 : MonoBehaviour {

    public void To_Main()
    {

        SceneManager.LoadScene("Main");
        k_var.isgameover = false;
        k_var.iswin = false;
        k_cteate_leve5.arr.Clear();

    }
    public void next_leve4()
    {

        SceneManager.LoadScene("leve4");
        k_cteate_leve5.arr.Clear();
        k_var.isgameover = false;
        k_var.iswin = false;
    }
    public void back_select()
    {
        SceneManager.LoadScene("Select_child");

    }
}
