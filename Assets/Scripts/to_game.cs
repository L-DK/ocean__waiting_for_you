using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_game : MonoBehaviour
{

    public void to_game1()
    {
        varDate.Go_Level_child = 1;
        Debug.Log("小关卡" + varDate.Go_Level_child);
        SceneManager.LoadScene("Select_Role");

    }
    public void to_game2()
    {
        varDate.Go_Level_child = 2;
        Debug.Log("小关卡" + varDate.Go_Level_child);
        SceneManager.LoadScene("Select_Role");

    }
    public void to_game3()
    {
        varDate.Go_Level_child = 3;
        Debug.Log("小关卡" + varDate.Go_Level_child);
        SceneManager.LoadScene("Select_Role");

    }
    public void to_game4()
    {
        varDate.Go_Level_child = 4;
        Debug.Log("小关卡" + varDate.Go_Level_child);
        SceneManager.LoadScene("Select_Role");

    }
    public void to_game5()
    {
        varDate.Go_Level_child = 5;
        Debug.Log("小关卡" + varDate.Go_Level_child);
        SceneManager.LoadScene("Select_Role");

    }
}
