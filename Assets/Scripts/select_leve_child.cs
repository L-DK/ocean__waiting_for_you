using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_leve_child : MonoBehaviour
{
    public GameObject leve_child_plane;
    public Sprite l1;
    public Sprite l2;
    public Sprite l3;
    public Sprite l4;
    void Start()
    {

        switch (varDate.Go_Level)
        {
            case 1:
                leve_child_plane.GetComponent<Image>().sprite = l1;
                break;
            case 2:
                leve_child_plane.GetComponent<Image>().sprite = l2;
                break;
            case 3:
                leve_child_plane.GetComponent<Image>().sprite = l3;
                break;
            case 4:
                leve_child_plane.GetComponent<Image>().sprite = l4;
                break;
            default:
                break;
        }

    }

}
