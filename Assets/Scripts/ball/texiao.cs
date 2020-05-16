using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texiao : MonoBehaviour {



     void Update()
    {
        Vector3 pos = this.transform.position;
        this.transform.position = new Vector3(pos.x,0.3f,pos.z);
    }


}
