using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LML_rubbishCol : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag== "staicrubbish")
        {
            Destroy(this.gameObject);

        }
        else if(col.gameObject.tag == "obstacle")
        {
            Destroy(this.gameObject);
        }

    }
}
