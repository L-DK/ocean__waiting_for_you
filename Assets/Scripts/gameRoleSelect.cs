using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRoleSelect : MonoBehaviour
{

    public GameObject root_role;
    Transform[] father;
    //public GameObject role1;
    //public GameObject role2;
    //public GameObject role3;
    void Start()
    {
        father = root_role.GetComponentsInChildren<Transform>();

        foreach (var child in father)
        {
            //Debug.Log(child.gameObject);
            if (child.name == varDate.role_name)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
        root_role.SetActive(true);

    }

}
